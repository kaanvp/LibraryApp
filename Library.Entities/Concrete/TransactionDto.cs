using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class TransactionDto
	{
		public int Id { get; set; }
		public int BookId { get; set; }
		public int UserId { get; set; }
		public DateTime TransactionDate { get; set; }
		public string TransactionType { get; set; }
		public string BookTitle { get; set; }
		public string UserName { get; set; }
		public DateTime? DueDate { get; set; }
		public DateTime? ReturnDate { get; set; }
		public string Status { get; set; }
		public decimal LateFee { get; set; } // Eklenen alan, gecikme ücreti
	}
}
