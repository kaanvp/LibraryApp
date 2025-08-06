using Library.Bussines.Managers;
using Library.DataAccess.Context;
using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library.WebFormsUI.ucBorrow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.WebFormsUI
{
	public partial class BorrowFrm : Form
	{
		private readonly TransactionLogManager _transactionLogManager;
		private Library.Bussines.Managers.BookManager _bookManager;
		private Library.Bussines.Managers.BorrowManager _borrowManager;
		public BorrowFrm()
		{
			InitializeComponent();
			_bookManager = new BookManager(new LibraryContext(new DbContextOptions<Library.DataAccess.Context.LibraryContext>()));
			_borrowManager = new BorrowManager();
			_transactionLogManager = new TransactionLogManager();
			LoadBooksFromDatabase();
			ReturnDaylbl.Text = UtilitiesClass._borrowDurationDays.ToString();
			UtilitiesClass.DatagridviewStyle(dataGridView1);
		}
		private void LoadBooksFromDatabase()
		{
			try
			{
				using (var context = new LibraryContext())
				{
					var books = context.Books
						.Include(b => b.Author).Where(b => b.Status == Book.BookStatus.Mevcut)
						.ToList();

					foreach (var book in books)
					{
						Image bookImage = null;

						if (book.CoverImage != null && book.CoverImage.Length > 0)
						{
							bookImage = Image.FromStream(new MemoryStream(book.CoverImage));
						}

						string authorName = book.Author.FullName;

						AddBookItems(book.Title, authorName, bookImage, book.Status, book.Id);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Kitaplar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void AddBookItems(string bookName, string author, Image bookImage, Book.BookStatus bookStatus, int id)
		{
			try
			{
				var bookControl = new ucBorrow()
				{
					Bookname = bookName,
					Authorname = author,
					PImage = bookImage,
					StatusBorrow = bookStatus,
					BookId = id,
				};
				bookControl.BookBorrowed += BookControl_BookBorrowed;
				// Panel'e ekle
				MainPanel.Controls.Add(bookControl);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Kitap eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BookControl_BookBorrowed(object sender, BookBorrowedEventArgs e)
		{

			if (dataGridView1.Rows.Count > UtilitiesClass._maxBorrowedBooks)
			{
				var message = new ErrorMessageFrm("En fazla 5 kitap ödünç alabilirsiniz.");
				message.TopMost = true;
				message.Show();
				dataGridView1.Rows.Clear(); // Listeyi temizle
				LoadBooksFromDatabase();
				return;
			}
			if (sender is ucBorrow borrowedBookControl)
			{
				borrowedBookControl.Visible = false;
			}

			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(dataGridView1); // dataGridView1 senin formundaki datagrid

			row.Cells[0].Value = e.BookId;
			row.Cells[1].Value = e.BookName;
			row.Cells[2].Value = e.AuthorName;
			dataGridView1.Rows.Add(e.BookId, e.BookName, e.AuthorName);
		}

		private void SearchTbx_TextChanged(object sender, EventArgs e)
		{
			var searchText = SearchTbx.Text.ToLower();
			var bookControls = MainPanel.Controls.OfType<ucBorrow>().ToList();
			foreach (var bookControl in bookControls)
			{
				// Kitap adını ve yazar adını küçük harfe çevirerek karşılaştırma yap
				if (bookControl.Bookname.ToLower().Contains(searchText) || bookControl.Authorname.ToLower().Contains(searchText))
				{
					bookControl.Visible = true; // Eşleşen kitapları göster
				}
				else
				{
					bookControl.Visible = false; // Eşleşmeyen kitapları gizle
				}
			}
		}

		private void BorrowFrm_Load(object sender, EventArgs e)
		{
			BorrowDatelbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
			DueDatelbl.Text = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
		}

		private void BorrowBtn_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells[0].Value != null)
				{
					int bookId = Convert.ToInt32(row.Cells[0].Value);

					// 1. Borrow kaydını oluştur
					Borrow borrow = new Borrow
					{
						BookId = bookId,
						UserId = Session.CurrentUser.UserId, // Oturum açan kullanıcıyı sen tanımlarsın
						BorrowDate = DateTime.Now,
						DueDate = DateTime.Now,
						ReturnDate = null
					};

					// 2. Borrow veritabanına ekle
					_borrowManager.Add(borrow);
					
					// 3. Kitabın durumunu 'OduncVerildi' yap
					_bookManager.UpdateStatus(bookId, Book.BookStatus.OduncVerildi);
					// 4. TransactionLog kaydını oluştur
					var transactionLog = new TransactionLog
					{
						BookId = bookId,
						UserId = Session.CurrentUser.UserId,
						TransactionDate = DateTime.Now,
						TransactionType = Book.BookStatus.OduncVerildi.ToString(),
						DueDate = DateTime.Now.AddDays(15), // Örneğin 15 günlük ödünç verme
						Status = "Aktif"
					};
					// 5. TransactionLog kaydını ekle
					_transactionLogManager.Add(transactionLog);
				}

			}

			var message = new MessageFrm("Kitap(lar) Başarıyla Ödünç Alındı");
			message.TopMost = true;
			message.Show();

			dataGridView1.Rows.Clear(); // Listeyi temizle
		}
	}
}
