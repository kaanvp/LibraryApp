using Library.Bussines.Interfaces;
using Library.DataAccess.Context;
using Library.DataAccess.Repositories;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bussines.Concrete
{
	public class TransactionLogDal : GenericRepository<TransactionLog>, ITransactionLogDal
	{
		public TransactionLogDal(LibraryContext context) : base(context)
		{
		}
	}
}
