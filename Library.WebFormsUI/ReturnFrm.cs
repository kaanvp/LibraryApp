using Library.Bussines.Managers;
using Library.DataAccess.Context;
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

namespace Library.WebFormsUI
{

	public partial class ReturnFrm : Form
	{
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
		}

		private void ReturnFrm_Load(object sender, EventArgs e)
		{
			var borrowedBooks = _borrowManager.GetDetailedBorrowedBooks();
			dataGridView1.DataSource = borrowedBooks;
		}
	}
}
