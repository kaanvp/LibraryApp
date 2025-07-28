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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library.WebFormsUI
{
	public partial class ManageBorrowFrm : Form
	{
		private Library.Bussines.Managers.BookManager _bookManager;
		public ManageBorrowFrm()
		{
			InitializeComponent();
			_bookManager = new Library.Bussines.Managers.BookManager(
						new Library.DataAccess.Context.LibraryContext(
							new Microsoft.EntityFrameworkCore.DbContextOptions<Library.DataAccess.Context.LibraryContext>()
						)
					);
		}
		private void LoadDataToDGV<T>(List<T> Data)
		{
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = Data;

			if (dataGridView1.Columns["Id"] != null)
				dataGridView1.Columns["Id"].Visible = false;

			if (dataGridView1.Columns["Title"] != null)
				dataGridView1.Columns["Title"].HeaderText = "Kitap Adı";

			if (dataGridView1.Columns["ISBN"] != null)
				dataGridView1.Columns["ISBN"].Visible = false;

			if (dataGridView1.Columns["Status"] != null)
				dataGridView1.Columns["Status"].HeaderText = "Durum";

			if (dataGridView1.Columns["AuthorName"] != null)
				dataGridView1.Columns["AuthorName"].HeaderText = "Yazar";

			if (dataGridView1.Columns["CategoryName"] != null)
				dataGridView1.Columns["CategoryName"].HeaderText = "Kategori";

			if (dataGridView1.Columns["LocationFullName"] != null)
				dataGridView1.Columns["LocationFullName"].HeaderText = "Kitap Konumu";
		}

		private void ManageBorrowFrm_Load(object sender, EventArgs e)
		{
			UtilitiesClass.DatagridviewStyle(dataGridView1);
			var books = _bookManager.GetAllBooksWithoutImage();
			LoadDataToDGV(books);

		}

		private void SearchTbx_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _bookManager.GetAllBooksWithoutImage()
		.Where(b => b.Title.ToLower().Contains(SearchTbx.Text.ToLower()) ||
					b.AuthorName.ToLower().Contains(SearchTbx.Text.ToLower()) ||
					b.CategoryName.ToLower().Contains(SearchTbx.Text.ToLower()) ||
					b.LocationFullName.ToLower().Contains(SearchTbx.Text.ToLower()))
		.ToList();
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Sütun adı "Status" ise (veya indexine göre de bakabilirsin)
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
			{
				if (e.Value != null)
				{
					string statusText = e.Value.ToString();

					switch (statusText)
					{
						case "Mevcut":
							e.CellStyle.BackColor = Color.SeaGreen;
							e.CellStyle.ForeColor = Color.White;
							break;

						case "GecikmisIade":
							e.CellStyle.BackColor = Color.IndianRed;
							e.CellStyle.ForeColor = Color.White;
							break;

						case "OduncVerildi":
							e.CellStyle.BackColor = Color.Orange;
							e.CellStyle.ForeColor = Color.White;
							break;

						default:
							e.CellStyle.BackColor = Color.LightGray;
							e.CellStyle.ForeColor = Color.Black;
							break;
					}
				}
			}
		}

		private void BorrowBtn_Click(object sender, EventArgs e)
		{
			MainForm.AddControls(new BorrowFrm());
		}

		private void ReturnBtn_Click(object sender, EventArgs e)
		{
			MainForm.AddControls(new ReturnFrm());
		}

		private void AvailableBtn_Click(object sender, EventArgs e)
		{
			var books = _bookManager.GetAllBooksWithoutImage().Where(p=>p.Status == Entities.Concrete.Book.BookStatus.Mevcut ).ToList();
			LoadDataToDGV(books);
		}

		private void CheckedOutBtn_Click(object sender, EventArgs e)
		{
			var books = _bookManager.GetAllBooksWithoutImage().Where(p => p.Status == Entities.Concrete.Book.BookStatus.OduncVerildi).ToList();
			LoadDataToDGV(books);
		}

		private void OverdueBtn_Click(object sender, EventArgs e)
		{
			var books = _bookManager.GetAllBooksWithoutImage().Where(p => p.Status == Entities.Concrete.Book.BookStatus.GecikmisIade).ToList();
			LoadDataToDGV(books);
		}
	}
}
