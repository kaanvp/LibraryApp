using Library.Bussines.Interfaces;
using Library.DataAccess.Context;
using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bussines.Managers
{
	public class BorrowManager : IBookService<Borrow>
	{
		private readonly IBookService<Borrow> _borrowDal;
		private readonly BookManager _bookDal;
		private readonly UserManager _userDal;
		
		public List<Borrow> GetAllBooksWithoutImage()
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				return context.Borrows
					.Include(b => b.Book)
					.Include(b => b.User)
					.ToList();
			}
		}

		void IBookService<Borrow>.AddBook(Borrow book)
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				context.Borrows.Add(book);
				context.SaveChanges();
			}
		}

		void IBookService<Borrow>.DeleteBook(int id)
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				var book = context.Borrows.Find(id);
				if (book != null)
				{
					context.Borrows.Remove(book);
					context.SaveChanges();
				}
			}
		}

		List<Borrow> IBookService<Borrow>.GetAllBooks()
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				return context.Borrows.ToList();
			}
		}

		Borrow IBookService<Borrow>.GetById(int id)
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				return context.Borrows.FirstOrDefault(b => b.Id == id);
			}
		}
		// Burası Bakılacak Ödün alan kişi neye göre arama yapacak
		List<Borrow> IBookService<Borrow>.GetBySearch(string entity)
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				return context.Borrows.ToList();
			}
		}
		public void Add(Borrow borrow)
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				context.Borrows.Add(borrow);
				context.SaveChanges();
			}
		}
		void IBookService<Borrow>.UpdateBook(Borrow book)
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				context.Borrows.Update(book);
				context.SaveChanges();
			}
		}
		public List<BorrowedBookDto> GetDetailedBorrowedBooks()
		{
			var books = _bookDal.GetAllBooksWithoutImage().ToList();
			var users = _userDal.GetAll().ToList();
			var borrows = _borrowDal.GetAllBooksWithoutImage().ToList();

			var result = from borrow in borrows
						 join user in users on borrow.UserId equals user.UserId
						 join book in books on borrow.BookId equals book.Id
						 where book.Status == Book.BookStatus.OduncVerildi
						 select new BorrowedBookDto
						 {
							 BookName = book.Title,
							 ISBN = book.ISBN,
							 UserName = user.UserName,
							 BorrowDate = borrow.BorrowDate,
							 DueDate = borrow.DueDate
						 };

			return result.ToList();
		}
	}
}
