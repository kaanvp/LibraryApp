using Library.Bussines.Interfaces;
using Library.DataAccess.Context;
using Library.DataAccess.Repositories;
using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Library.Bussines.Managers
{
    public class BookManager : IBookService<Book>
    {
        private readonly GenericRepository<Book> _bookRepository;
        private readonly LibraryContext _context;

        public BookManager(LibraryContext context)
        {
            _context = context;
            _bookRepository = new GenericRepository<Book>(context);
        }

        public void AddBook(Book book) => _bookRepository.Add(book);

        public void DeleteBook(int id)
        {
            var book = _bookRepository.Get(id);
            if (book != null)
            {
                _bookRepository.Delete(book);
            }
        }

        public List<BookDto> GetAllBooksWithDetails()
        {
            var result = from book in _context.Books
                         join author in _context.Authors on book.AuthorId equals author.Id
                         join category in _context.Categories on book.CategoryId equals category.Id
                         join location in _context.Locations on book.LocationId equals location.Id
                         join ısbn in _context.Books on book.ISBN equals ısbn.ISBN
						 select new BookDto
                         {
                             Id = book.Id,
                             Title = book.Title,
                             ISBN = book.ISBN,
							 AuthorName = author.FullName,
                             CategoryName = category.Name,
                             LocationFullName = location.FullLocation,
                             Image = book.CoverImage
						 };
            return result.ToList();
        }

		public List<BookDtoForBorrow> GetAllBooksWithoutImage()
        {
			var results = from book in _context.Books
						  join author in _context.Authors on book.AuthorId equals author.Id
						  join category in _context.Categories on book.CategoryId equals category.Id
						  join location in _context.Locations on book.LocationId equals location.Id
						  join ısbn in _context.Books on book.ISBN equals ısbn.ISBN

						  select new BookDtoForBorrow
						  {
							  Id = book.Id,
							  Title = book.Title,
							  ISBN = book.ISBN,
							  Status = book.Status,
							  AuthorName = author.FullName,
							  CategoryName = category.Name,
							  LocationFullName = location.FullLocation,

						  };
			return results.ToList();
		}
		public List<Book> GetAllBooks()
        {
            return _context.Books
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Location)
                .ToList();
		}

		public Book GetById(int id) => _bookRepository.Get(id);

        public List<Book> GetBySearch(string entity)
        {
            return _context.Books
                .Where(b => b.Title.ToLower().Contains(entity.ToLower()) ||
                            b.Author.FullName.ToLower().Contains(entity.ToLower()))
                .ToList();
        }
        public void GetBooksFromDatabase()
        {
			using (var context = new LibraryContext())
            {
                var books = context.Books.ToList();
                foreach (var book in books)
                {
                    // İşlemler
                }
			}
		}
		public void UpdateStatus(int bookId, Book.BookStatus newStatus)
		{
			using var context = new LibraryContext();
			var book = context.Books.Find(bookId);
			if (book != null)
			{
				book.Status = newStatus;
				context.SaveChanges();
			}
		}

		public void UpdateBook(Book book) => _bookRepository.Update(book);

		List<Book> IBookService<Book>.GetAllBooksWithoutImage()
		{
			throw new NotImplementedException();
		}

		public Borrow Get(Func<object, bool> value)
		{
			throw new NotImplementedException();
		}
	}
}
