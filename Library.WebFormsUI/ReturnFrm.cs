using Library.Bussines.Managers;
using Library.DataAccess.Context;
using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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

namespace Library.WebFormsUI
{

	public partial class ReturnFrm : Form
	{
		private readonly TransactionLogManager _transactionLogManager;
		private readonly BookManager _bookManager;
		private readonly UserManager _userManager;
		private readonly BorrowManager _borrowManager;
		public ReturnFrm()
		{
			InitializeComponent();
			_bookManager = new Library.Bussines.Managers.BookManager(
						new Library.DataAccess.Context.LibraryContext(
							new Microsoft.EntityFrameworkCore.DbContextOptions<Library.DataAccess.Context.LibraryContext>()
						)
					);
			_userManager = new UserManager();
			_borrowManager = new BorrowManager();
			_transactionLogManager = new TransactionLogManager();
			LoadBooksFromDatabase();
			UtilitiesClass.DatagridviewStyle(dataGridView1);
		}
		private void LoadBooksFromDatabase()
		{
			try
			{
				using (var context = new LibraryContext())
				{
					var books = context.Books
						.Include(b => b.Author).Where(b => b.Status == Book.BookStatus.OduncVerildi || b.Status == Book.BookStatus.GecikmisIade)
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
					ButtonText = "İade Et"
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
		private void ReturnFrm_Load(object sender, EventArgs e)
		{
			DueDatelbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				try
				{
					int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					var borrow = _borrowManager.GetById(bookId);

					if (borrow != null)
					{
						BorrowDatelbl.Text = borrow.BorrowDate.ToString("dd/MM/yyyy");
						int dayDiff = (DateTime.Now - borrow.DueDate).Days;
						ReturnDaylbl.Text = dayDiff.ToString();
					}
					else
					{
						BorrowDatelbl.Text = "-";
						ReturnDaylbl.Text = "-";
					}
				}
				catch (Exception ex)
				{
					BorrowDatelbl.Text = "-";
					ReturnDaylbl.Text = "-";
					MessageBox.Show("Kitap bilgileri yüklenirken bir hata oluştu.", "Hata",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ReturnBtn_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells[0].Value != null)
				{
					int bookId = Convert.ToInt32(row.Cells[0].Value);

					// 1. Mevcut borrow kaydını bul
					var activeBorrow = _borrowManager.GetById(bookId);
					if (activeBorrow != null)
					{
						// 2. İade tarihini set et
						activeBorrow.ReturnDate = DateTime.Now;
						_borrowManager.Update(activeBorrow);

						// 3. Kitabın durumunu güncelle
						_bookManager.UpdateStatus(bookId, Book.BookStatus.Mevcut);

						// 4. TransactionLog kaydını oluştur
						var transactionLog = new TransactionLog
						{
							BookId = bookId,
							UserId = Session.CurrentUser.UserId,
							TransactionDate = DateTime.Now,
							TransactionType = Book.BookStatus.Mevcut.ToString(),
							ReturnDate = DateTime.Now, // Önemli: ReturnDate'i set et
							DueDate = activeBorrow.DueDate, // Önceki DueDate'i kopyala
							Status = "Tamamlandı"
						};

						_transactionLogManager.Add(transactionLog);
					}
				}
			}

			var message = new MessageFrm("Kitap(lar) Başarıyla İade Edildi");
			message.TopMost = true;
			message.Show();

			dataGridView1.Rows.Clear();
			LoadBooksFromDatabase(); // Listeyi yenile
		}
	}
}
