using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class TransactionLog
	{
		public int Id { get; set; }
		public int BookId { get; set; }
		public int UserId { get; set; }
		public DateTime TransactionDate { get; set; }
		public string TransactionType { get; set; } // "Borrow" veya "Return"
		public DateTime? DueDate { get; set; }  // İade tarihi
		public DateTime? ReturnDate { get; set; } // Gerçek iade tarihi
		public string Status { get; set; } // "Active", "Completed", "Overdue"

		// Navigation Properties
		public virtual Book Book { get; set; }
		public virtual User User { get; set; }

	}
}
