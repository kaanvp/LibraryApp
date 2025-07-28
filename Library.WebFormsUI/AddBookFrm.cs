using Library.Bussines.Managers;
using Library.DataAccess.Context;
using Library.Entities.Concrete;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Library.WebFormsUI
{
	public partial class AddBookFrm : Form
	{
		private readonly BookManager _bookManager;
		private readonly AuthorManager _authorManager;
		private readonly CategoryManager _categoryManager;
		private readonly LocationManager _locationManager;

		public AddBookFrm()
		{
			InitializeComponent();
			var context = new Library.DataAccess.Context.LibraryContext();
			_bookManager = new BookManager(context);
			_authorManager = new AuthorManager();
			_categoryManager = new CategoryManager();
			_locationManager = new LocationManager();
		}

		private byte[] imageBytes;

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

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AddBookFrm_Load(object sender, EventArgs e)
		{
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
		private void SaveBtn_Click(object sender, EventArgs e)
		{
			// Yazar işlemleri
			var authorName = Authorscbx.Text;
			var author = _authorManager.GetByName(authorName); 

			// Kategori işlemleri
			var categoryName = Categorycbx.Text;
			var category = _categoryManager.GetByName(categoryName); 

			// Konum işlemleri
			var locationName = Locationcbx.Text;
			var location = _locationManager.GetByFullLocation(locationName); 
			
			// Kitap oluştur
			var book = new Book
			{
				Title = BookNameTbx.Text,
				AuthorId = author.Id,
				CategoryId = category.Id,
				LocationId = location.Id,
				CoverImage = imageBytes,
				ISBN = ISBNTbx.Text,
				Stock = 1
				
			};

			_bookManager.AddBook(book);
			var message = new MessageFrm("Kitap başarıyla eklendi.");
			message.TopMost = true;
			message.Show();
		}
	}
}