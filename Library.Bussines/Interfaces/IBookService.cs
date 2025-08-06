using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bussines.Interfaces
{
	public interface IBookService<T> where T : class
	{
		List<T> GetAllBooks();
		List<T> GetAllBooksWithoutImage();
		void AddBook(T book);
		T GetById(int id);
		List<T> GetBySearch(string entity);
		void UpdateBook(T book);
		void DeleteBook(int id);
		Borrow Get(Func<object, bool> value);
	}
}
