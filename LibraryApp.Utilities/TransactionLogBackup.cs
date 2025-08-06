using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Utilities
{
	public static class TransactionLogBackup
	{
		public static int _maxBorrowedBooks = 5;
		public static int _borrowDurationDays = 14;
		public static int _extensionPeriodDays = 7;
		public static decimal _lateFeePerDay = 2;
	}
}
