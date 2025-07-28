using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class Category 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Book> Books { get; set; }
	}
}
