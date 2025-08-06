using Library.DataAccess.Context;
using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bussines.Interfaces
{
	// Library.DataAccess.Repositories > EfBorrowRepository.cs
	public class EfBorrowRepository : IBookService<Borrow>
	{
		public void AddBook(Borrow book)
		{
			throw new NotImplementedException();
		}

		public void DeleteBook(int id)
		{
			throw new NotImplementedException();
		}

		public Borrow Get(Func<object, bool> value)
		{
			throw new NotImplementedException();
		}

		public List<Borrow> GetAllBooks()
		{
			throw new NotImplementedException();
		}

		public List<Borrow> GetAllBooksWithoutImage()
		{
			using (var context = new LibraryContext())
			{
				return context.Borrows
					.Include(b => b.Book)
					.Include(b => b.User)
					.ToList();
			}
		}

		public Borrow GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Borrow> GetBySearch(string entity)
		{
			throw new NotImplementedException();
		}

		public void UpdateBook(Borrow book)
		{
			throw new NotImplementedException();
		}

		// Diğer Add, Update vs...
	}

}
