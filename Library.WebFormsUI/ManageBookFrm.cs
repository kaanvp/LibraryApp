using Library.Bussines.Managers;
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
	public partial class ManageBookFrm : Form
	{
		private Library.Bussines.Managers.BookManager _bookManager;

		public ManageBookFrm()
		{
			InitializeComponent();
			_bookManager = new Library.Bussines.Managers.BookManager(
						new Library.DataAccess.Context.LibraryContext(
							new Microsoft.EntityFrameworkCore.DbContextOptions<Library.DataAccess.Context.LibraryContext>()
						)
					);
		}

		private void ManageBookFrm_Load(object sender, EventArgs e)
		{
			UtilitiesClass.DatagridviewStyle(dataGridView1);

			dataGridView1.DataSource = _bookManager.GetAllBooksWithDetails();

			dataGridView1.Columns["Id"].Visible = false; // Id sütununu gizle
			dataGridView1.Columns["ISBN"].Visible = false; // ISBN sütununu gizle
			dataGridView1.Columns["Image"].Visible = false; // Resim sütununu gizle
			dataGridView1.Columns["Title"].HeaderText = "Kitap Adı";
			dataGridView1.Columns["AuthorName"].HeaderText = "Yazar";
			dataGridView1.Columns["CategoryName"].HeaderText = "Kategori";
			dataGridView1.Columns["LocationFullName"].HeaderText = "Kitap Konumu";
			dataGridView1.VirtualMode = true;

		}
		private void RefreshBookGrid()
		{
			dataGridView1.DataSource = _bookManager.GetAllBooksWithDetails();
		}
		private void SearchTbx_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _bookManager.GetAllBooksWithDetails()
		.Where(b => b.Title.ToLower().Contains(SearchTbx.Text.ToLower()) ||
					b.AuthorName.ToLower().Contains(SearchTbx.Text.ToLower()) ||
					b.CategoryName.ToLower().Contains(SearchTbx.Text.ToLower()) ||
					b.LocationFullName.ToLower().Contains(SearchTbx.Text.ToLower()))
		.ToList();
		}

		private void AddBookBtn_Click(object sender, EventArgs e)
		{
			UtilitiesClass.BlurBackground(new AddBookFrm(), this);
		}

		private void UpdateBookBtn_Click(object sender, EventArgs e)
		{
			UtilitiesClass.BlurBackground(new UpdateBookFrm(), this);
		}

		private void DeleteBookBtn_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				var confirmResult = MessageBox.Show("Seçilen kitabı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmResult == DialogResult.No)
				{
					return; // Kullanıcı silmeyi iptal etti
				}
				else if (confirmResult == DialogResult.Yes)
				{
					// Silme işlemi
					int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
					_bookManager.DeleteBook(bookId);
					RefreshBookGrid();
					var message = new MessageFrm("Kitap başarıyla silindi.");
					message.TopMost = true;
					message.Show();
				}

			}
			else
			{
				MessageBox.Show("Silmek için bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
