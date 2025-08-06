using FluentValidation;
using Library.Bussines.Managers;
using Library.Bussines.ValidationRules.FluentValidation;
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
		private BookValidator _validator = new BookValidator();
		public AddBookFrm()
		{
			InitializeComponent();
			var context = new Library.DataAccess.Context.LibraryContext();
			_bookManager = new BookManager(context);
			_authorManager = new AuthorManager();
			_categoryManager = new CategoryManager();
			_locationManager = new LocationManager();
			_validator = new BookValidator(); 
		}

		private byte[] imageBytes;

		private void ImageBtn_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					imageBytes = File.ReadAllBytes(ofd.FileName);
					Pictxt.Image = Image.FromFile(ofd.FileName);
				}
				else
				{
					// Kullanıcı resim seçmediyse, varsayılan resmi yükle
					string defaultImagePath = @"C:\Users\vural\source\repos\LibraryManagementSystem\Library.WebFormsUI\Assets\no-image-icon-23483.png";

					if (File.Exists(defaultImagePath))
					{
						imageBytes = File.ReadAllBytes(defaultImagePath);
						Pictxt.Image = Image.FromFile(defaultImagePath);
					}
					else
					{
						MessageBox.Show("Varsayılan resim bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
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
			// Değişkenleri başta tanımla
			Author author = null;
			Category category = null;
			Location location = null;

			// Author işlemleri
			var authorName = Authorscbx.Text;
			if (!string.IsNullOrWhiteSpace(authorName))
			{
				author = _authorManager.GetByName(authorName);
			}

			// Kategori işlemleri
			var categoryName = Categorycbx.Text;
			if (!string.IsNullOrWhiteSpace(categoryName))
			{
				category = _categoryManager.GetByName(categoryName);
			}

			// Konum işlemleri
			var locationName = Locationcbx.Text;
			if (!string.IsNullOrWhiteSpace(locationName))
			{
				location = _locationManager.GetByFullLocation(locationName);
			}

			// Resim Eklenmediyse
			if (imageBytes == null)
			{
				// Kullanıcı resim seçmediyse, varsayılan resmi yükle
				string defaultImagePath = @"C:\Users\vural\source\repos\LibraryManagementSystem\Library.WebFormsUI\Assets\no-image-icon-23483.png";
				if (File.Exists(defaultImagePath))
				{
					imageBytes = File.ReadAllBytes(defaultImagePath);
				}
				else
				{
					MessageBox.Show("Varsayılan resim bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return; // Resim yoksa işlemi durdur
				}
			}

			// Kitap oluştur - Null değerlerle bile, validation handle edecek
			var book = new Book
			{
				Title = BookNameTbx.Text,
				AuthorId = author?.Id ?? 0, // Null ise 0 ata
				CategoryId = category?.Id ?? 0, // Null ise 0 ata
				LocationId = location?.Id ?? 0, // Null ise 0 ata
				CoverImage = imageBytes,
				ISBN = ISBNTbx.Text,
				Stock = 1
			};

			var validation = _validator.Validate(book);
			if (!validation.IsValid)
			{
				var errorMessage = string.Join(Environment.NewLine, validation.Errors.Select(e => e.ErrorMessage));
				var message = new ErrorMessageFrm(errorMessage);
				message.TopMost = true;
				message.Show();
				return;
			}
			else
			{
				_bookManager.AddBook(book);
				var successMessage = new MessageFrm("Kitap başarıyla eklendi.");
				successMessage.TopMost = true;
				successMessage.Show();
			}
		}
	}
}