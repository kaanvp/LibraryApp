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
	public partial class ucBorrow : UserControl
	{
		public ucBorrow()
		{
			InitializeComponent();
		}
		public int BookId { get; set; }
		public string? Bookname
		{
			get { return BookNameuc.Text; }
			set { BookNameuc.Text = value; }
		}
		public string? Authorname
		{
			get { return AuthorNameuc.Text; }
			set { AuthorNameuc.Text = value; }
		}
		public Image? PImage
		{
			get { return Imageuc.Image; }
			set { Imageuc.Image = value; }
		}
		public string? ButtonText
		{
			get { return BorrowBtn.Text; }
			set { BorrowBtn.Text = value; }
		}
		private Book.BookStatus _status;
		public event EventHandler<BookBorrowedEventArgs> BookBorrowed;
		private void BorrowBtn_Click(object sender, EventArgs e)
		{
			if (BookBorrowed != null)
			{
				BookBorrowed(this, new BookBorrowedEventArgs()
				{
					BookId = this.BookId,
					BookName = this.Bookname,
					AuthorName = this.Authorname,
				});
			}
		}
		public class BookBorrowedEventArgs : EventArgs
		{
			public int BookId { get; set; }
			public string BookName { get; set; }
			public string AuthorName { get; set; }
		}

		public Book.BookStatus StatusBorrow
		{
			get { return _status; }
			set
			{
				_status = value;
				StatusBtn.Text = value switch
				{
					Book.BookStatus.Mevcut => "Mevcut",
					Book.BookStatus.OduncVerildi => "Ödünç Verildi",
					Book.BookStatus.GecikmisIade => "Gecikmiş",
					_ => "Bilinmiyor"
				};

				StatusBtn.ControlBackColor = value switch
				{
					Book.BookStatus.Mevcut => Color.LightGreen,
					Book.BookStatus.OduncVerildi => Color.Goldenrod,
					Book.BookStatus.GecikmisIade => Color.IndianRed,
					_ => Color.Gray
				};
				StatusBtn.BorderColor = value switch
				{
					Book.BookStatus.Mevcut => Color.LightGreen,
					Book.BookStatus.OduncVerildi => Color.Goldenrod,
					Book.BookStatus.GecikmisIade => Color.IndianRed,
					_ => Color.Gray
				};
				StatusBtn.BorderColorOnButtonPress = value switch
				{
					Book.BookStatus.Mevcut => Color.LightGreen,
					Book.BookStatus.OduncVerildi => Color.Goldenrod,
					Book.BookStatus.GecikmisIade => Color.IndianRed,
					_ => Color.Gray
				};
				StatusBtn.BorderColorOnHover = value switch
				{
					Book.BookStatus.Mevcut => Color.LightGreen,
					Book.BookStatus.OduncVerildi => Color.Goldenrod,
					Book.BookStatus.GecikmisIade => Color.IndianRed,
					_ => Color.Gray
				};


			}
		}
	}

}
