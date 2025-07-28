using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class Borrow 
	{
		public int Id { get; set; }

		public int BookId { get; set; }
		public int UserId { get; set; }  // Artık Member değil, User olacak

		public DateTime BorrowDate { get; set; }
		public DateTime DueDate { get; set; }
		public DateTime? ReturnDate { get; set; }

		public Book Book { get; set; }
		public User User { get; set; }
	}
}
