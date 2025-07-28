using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class Author
	{
		public int Id { get; set; }
		public string FullName { get; set; }

		public ICollection<Book> Books { get; set; }
	}
}
