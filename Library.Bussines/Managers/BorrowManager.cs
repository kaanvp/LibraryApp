using Library.Bussines.Interfaces;
using Library.DataAccess.Context;
using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
				return context.Borrows
					.FirstOrDefault(b => b.BookId == id && b.ReturnDate == null);
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

		public Borrow GetById(int bookId)
		{
			using(var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				return context.Borrows
					.Include(b => b.Book)
					.Include(b => b.User)
					.FirstOrDefault(b => b.BookId == bookId && b.ReturnDate == null);
			}
		}
		public void CheckOverdueBooks()
		{
            using (var context = new LibraryContext())
            {
                // İade edilmemiş ve süresi geçmiş kitapları bul
                var overdueBooks = context.Borrows
                    .Include(b => b.Book)
                    .Include(b => b.User)
                    .Where(b => b.ReturnDate == null && b.DueDate < DateTime.Now)
                    .ToList();

                foreach (var borrow in overdueBooks)
                {
                    // Kitabın durumu zaten GecikmisIade değilse
                    if (borrow.Book.Status != Book.BookStatus.GecikmisIade)
                    {
                        // Gecikme gününü hesapla
                        int daysLate = (DateTime.Now.Date - borrow.DueDate.Date).Days;
                        if (daysLate <= 0) continue; // önlem

                        // Log ekle (kitap hala kullanıcıda)
                        var transactionLog = new TransactionLog
                        {
                            BookId = borrow.BookId,
                            UserId = borrow.UserId,
                            TransactionDate = DateTime.Now,
                            TransactionType = "Gecikme Uyarısı",
                            DueDate = borrow.DueDate,
                            ReturnDate = null, // çünkü iade edilmedi
                            Status = "Teslim Edilmedi - Gecikmiş",
                        };

                        context.TransactionLogs.Add(transactionLog);

                        // Kitabın durumu sadece görsel olarak değiştirilsin
                        borrow.Book.Status = Book.BookStatus.GecikmisIade;

                        context.SaveChanges();
                    }
                }
            }
        }
		public void Update(Borrow activeBorrow)
		{
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				context.Borrows.Update(activeBorrow);
				context.SaveChanges();
			}
		}

		public Borrow Get(Func<object, bool> value)
		{
			throw new NotImplementedException();
		}
		public void CheckOverDueBookForTransactionlog()
		{
			using (var context = new LibraryContext())
			{
				// İade edilmemiş ve süresi geçmiş kitapları bul
				var overdueBooks = context.Borrows
					.Include(b => b.Book)
					.Where(b => b.ReturnDate == null && b.DueDate < DateTime.Now)
					.ToList();

				foreach (var borrow in overdueBooks)
				{
					// Kitabın durumunu GecikmisIade olarak güncelle
					if (borrow.Book.Status != Book.BookStatus.GecikmisIade)
					{
						// Otomatik iade işlemi
						borrow.ReturnDate = DateTime.Now;
						borrow.Book.Status = Book.BookStatus.GecikmisIade;

						// Gecikme kaydını TransactionLog'a ekle
						var transactionLog = new TransactionLog
						{
							BookId = borrow.BookId,
							UserId = borrow.UserId,
							TransactionDate = DateTime.Now,
							TransactionType = Book.BookStatus.GecikmisIade.ToString(),
							ReturnDate = DateTime.Now,
							DueDate = borrow.DueDate,
							Status = "Gecikmeli İade",
						};

						context.TransactionLogs.Add(transactionLog);
						context.SaveChanges();
					}
				}
			}
		}
	}
}
