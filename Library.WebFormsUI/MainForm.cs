using Library.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUI
{
	public partial class MainForm : Form
	{
		public static Panel CenterPanelReference;

		private string _role;
		public MainForm(string role)
		{
			InitializeComponent();
			_role = role; // Kullanıcı rolünü al 
			CenterPanelReference = this.CenterPanel;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (_role == "admin")
			{
				//ekleme silme işlemleri için butonlar görünür
			}
			else if (_role == "kullanıcı")
			{
				// Kullanıcı rolü için butonları gizle
			}
			LoadBooksFromDatabase();
		}
		// businnes katmanından import edilemiyor tool'dan dolayı direkt olarak DbContext üzerinden kitapları alıyoruz.
		private void LoadBooksFromDatabase()
		{
			try
			{
				using (var context = new LibraryContext()) // DbContext'inizin adını buraya yazın
				{
					var books = context.Books.ToList(); // Books tablosundan tüm kitapları al
					var authors = context.Authors.ToList(); // Authors tablosundan tüm yazarları al

					foreach (var book in books)
					{
						Image bookImage = null;

						// Eğer kitap resmi varsa byte array'den Image'a çevir
						if (book.CoverImage != null && book.CoverImage.Length > 0)
						{
							bookImage = Image.FromStream(new MemoryStream(book.CoverImage));
						}
						var author = authors.FirstOrDefault(a => a.Id == book.AuthorId);
						// Kitabı panele ekle
						AddBookItems(book.Title, author.FullName, bookImage);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Kitaplar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Kitap öğelerini FlowLayoutPanel'e ekle
		public void AddBookItems(string bookName, string author, Image bookImage)
		{
			try
			{
				var bookControl = new ucBook()
				{
					Bookname = bookName,
					Authorname = author,
					PImage = bookImage,
				};

				MainPanel.Controls.Add(bookControl);

				// Kitap seçildiğinde yapılacak işlemler (isteğe bağlı)
				/*
				bookControl.onBookSelect += (sender, e) =>
				{
					var selectedBook = (ucBook)sender;
					// Burada kitap seçildiğinde yapılacak işlemleri yazabilirsiniz
					MessageBox.Show($"Seçilen kitap: {selectedBook.BookName}", "Kitap Seçildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				};
				*/
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Kitap eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static void AddControls(Form F)
		{
			CenterPanelReference.Controls.Clear();
			F.Dock = DockStyle.Fill;
			F.TopLevel = false;
			CenterPanelReference.Controls.Add(F);
			F.Show();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				this.WindowState = FormWindowState.Maximized;
			}
			else
			{
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void ManageBookBtn_Click(object sender, EventArgs e)
		{
			AddControls(new ManageBookFrm());
		}

		private void ucBook1_Load(object sender, EventArgs e)
		{

		}

		private void SearchTbx_TextChanged(object sender, EventArgs e)
		{
			var searchText = SearchTbx.Text.ToLower();
			var bookControls = MainPanel.Controls.OfType<ucBook>().ToList();
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

		private void ManageUserBtn_Click(object sender, EventArgs e)
		{
			AddControls(new ManageUserFrm());
		}

		private void ManageBorrowBtn_Click(object sender, EventArgs e)
		{
			AddControls(new ManageBorrowFrm());
		}
	}
}
