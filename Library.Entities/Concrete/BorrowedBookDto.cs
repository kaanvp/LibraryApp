using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class BorrowedBookDto
	{
		public string BookName { get; set; }
		public string ISBN { get; set; }
		public string UserName { get; set; }
		public DateTime BorrowDate { get; set; }
		public DateTime DueDate { get; set; }
	}
}
