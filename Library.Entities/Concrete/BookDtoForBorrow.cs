using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class BookDtoForBorrow
	{
		public Book.BookStatus Status { get; set; }
		public int Id { get; set; }
		public string Title { get; set; }
		public string AuthorName { get; set; } // Author.Name
		public string ISBN { get; set; }
	
		public string CategoryName { get; set; } // Category.Name
		public string LocationFullName
		{
			get; set;
		}
		
	}
}
