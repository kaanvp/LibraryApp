using Library.Bussines.Managers;
using Library.Entities.Concrete;
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
	public partial class UpdateBookFrm : Form
	{
		private readonly BookManager _bookManager;
		private readonly AuthorManager _authorManager;
		private readonly CategoryManager _categoryManager;
		private readonly LocationManager _locationManager;
		private byte[] imageBytes;

		public UpdateBookFrm()
		{
			InitializeComponent();
			var context = new Library.DataAccess.Context.LibraryContext();
			_bookManager = new BookManager(context);
			_authorManager = new AuthorManager();
			_categoryManager = new CategoryManager();
			_locationManager = new LocationManager();
		}
		private void RefreshDataGridView(DataGridView dgv)
		{
			// DataGridView'e verileri bağla
			dgv.DataSource = _bookManager.GetAllBooksWithDetails();
			// verilerin doğru etiketlerle gösterilmesi için sütun başlıklarını ayarla
			dgv.Columns["Id"].Visible = false; // Id sütununu gizle
			dgv.Columns["ISBN"].Visible = false; // ISBN sütununu gizle
			dgv.Columns["Image"].Visible = false; // Resim sütununu gizle
			dgv.Columns["Title"].HeaderText = "Kitap Adı";
			dgv.Columns["AuthorName"].HeaderText = "Yazar";
			dgv.Columns["CategoryName"].HeaderText = "Kategori";
			dgv.Columns["LocationFullName"].HeaderText = "Kitap Konumu";
			dgv.VirtualMode = true;
		}
		private void UpdateBookFrm_Load(object sender, EventArgs e)
		{
			UtilitiesClass.DatagridviewStyle(dataGridView1);
			RefreshDataGridView(dataGridView1);

			// Combobox'ları doldur
			Categorycbx.DataSource = _categoryManager.GetAll();
			Categorycbx.DisplayMember = "Name";
			Categorycbx.ValueMember = "Id";

			Authorscbx.DataSource = _authorManager.GetAll();
			Authorscbx.DisplayMember = "FullName";
			Authorscbx.ValueMember = "Id";

			Locationcbx.DataSource = _locationManager.GetAll();
			Locationcbx.DisplayMember = "FullLocation";
			Locationcbx.ValueMember = "Id";

			Authorscbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			Authorscbx.AutoCompleteSource = AutoCompleteSource.ListItems;
			Categorycbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			Categorycbx.AutoCompleteSource = AutoCompleteSource.ListItems;
			Locationcbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			Locationcbx.AutoCompleteSource = AutoCompleteSource.ListItems;

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

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				BookNameTbx.Text = dataGridView1.CurrentRow.Cells["Title"].Value?.ToString();
				Authorscbx.Text = dataGridView1.CurrentRow.Cells["AuthorName"].Value?.ToString();
				Categorycbx.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value?.ToString();
				Locationcbx.Text = dataGridView1.CurrentRow.Cells["LocationFullName"].Value?.ToString();
				ISBNTbx.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value?.ToString();

				// CoverImage çekilecek alan:
				var imageCell = dataGridView1.CurrentRow.Cells["Image"].Value;

				if (imageCell != null && imageCell is byte[] bytes && bytes.Length > 0)
				{
					try
					{
						using (var ms = new MemoryStream(bytes))
						{
							Pictxt.Image = Image.FromStream(ms);
						}
					}
					catch
					{
						Pictxt.Image = null; // Bozuksa boş bırak
					}
				}
				else
				{
					Pictxt.Image = null; // Resim yoksa temizle
				}
			}
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			try
			{
				byte[] imageBytes = null;

				if (Pictxt.Image != null)
				{
					using (MemoryStream ms = new MemoryStream())
					{
						Bitmap temp = new Bitmap(Pictxt.Image);
						temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
						imageBytes = ms.ToArray();
					}
				}

				int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

				var existingBook = _bookManager.GetById(bookId);
				if (existingBook == null)
				{
					MessageBox.Show("Kitap bulunamadı!");
					return;
				}

				existingBook.Title = BookNameTbx.Text;
				existingBook.AuthorId = Convert.ToInt32(Authorscbx.SelectedValue);
				existingBook.CategoryId = Convert.ToInt32(Categorycbx.SelectedValue);
				existingBook.LocationId = Convert.ToInt32(Locationcbx.SelectedValue);
				existingBook.ISBN = ISBNTbx.Text;

				// Yeni resim varsa güncelle, yoksa eskiyi koru
				if (imageBytes != null)
				{
					existingBook.CoverImage = imageBytes;
				}

				_bookManager.UpdateBook(existingBook);

				var message = new MessageFrm("Kitap Başarıyla Güncellendi");
				message.TopMost = true;
				message.Show();

				RefreshDataGridView(dataGridView1);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message);
			}
		}

		private void ImageBtn_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					imageBytes = System.IO.File.ReadAllBytes(ofd.FileName);
					Pictxt.Image = Image.FromFile(ofd.FileName);
				}
			}
		}
	}
}
