using Library.Bussines.Concrete;
using Library.Bussines.Interfaces;
using Library.DataAccess.Context;
using Library.Entities.Concrete;
using LibraryApp.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bussines.Managers
{
	public class TransactionLogManager
	{
		private readonly ITransactionLogDal _transactionLogDal;
		private readonly BookManager _bookManager;
		private readonly UserManager _userManager;

		public TransactionLogManager()
		{
			var context = new LibraryContext(new DbContextOptions<LibraryContext>());
			_transactionLogDal = new TransactionLogDal(context);
			_bookManager = new BookManager(context);
			_userManager = new UserManager();
		}
		public void Add(TransactionLog log)
		{
			_transactionLogDal.Add(log);
			
		}

		public List<TransactionDto> GetAll()
		{
			try
			{
				if (_transactionLogDal == null || _bookManager == null || _userManager == null)
				{
					throw new InvalidOperationException("Managers not properly initialized");
				}

				var logs = _transactionLogDal.GetAll();
				if (logs == null) return new List<TransactionDto>();

				var books = _bookManager.GetAllBooksWithoutImage();
				var users = _userManager.GetAll();

				var results = from log in logs
							  join book in books on log.BookId equals book.Id
							  join user in users on log.UserId equals user.UserId
							  select new TransactionDto
							  {
								  Id = log.Id,
								  BookId = log.BookId,
								  UserId = log.UserId,
								  TransactionDate = log.TransactionDate,
								  TransactionType = log.TransactionType,
								  BookTitle = book.Title,
								  UserName = user.UserName,
								  DueDate = log.DueDate,
								  ReturnDate = log.ReturnDate,
								  Status = log.Status,
								  LateFee = CalculateLateFee(log.DueDate, log.ReturnDate)
							  };

				return results.OrderByDescending(i => i.TransactionDate).ToList();
			}
			catch (Exception ex)
			{
				// Log the error if you have logging
				throw new Exception("Error getting transaction logs", ex);
			}
		}
		private decimal CalculateLateFee(DateTime? dueDate, DateTime? returnDate)
		{
			if (!dueDate.HasValue) return 0;

			// Eğer iade tarihi yoksa ve due date geçmişse, şimdiki tarihe göre hesapla
			DateTime effectiveReturnDate;
			if (!returnDate.HasValue)
			{
				if (DateTime.Now > dueDate.Value)
				{
					effectiveReturnDate = DateTime.Now;
				}
				else
				{
					return 0; // Henüz gecikme yok
				}
			}
			else
			{
				effectiveReturnDate = returnDate.Value;
			}

			// Due date'i geçmişse ceza hesapla
			if (effectiveReturnDate > dueDate.Value)
			{
				var daysLate = (effectiveReturnDate - dueDate.Value).Days;
				return daysLate * TransactionLogBackup._lateFeePerDay;
			}

			return 0;
		}
	}
}
