using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string ISBN { get; set; }
		public int Stock { get; set; }

		public int AuthorId { get; set; }
		public int CategoryId { get; set; }
		public int LocationId { get; set; }
		public byte[] CoverImage { get; set; }
		public BookStatus Status { get; set; } // enum alanı
		public Author Author { get; set; }
		public Category Category { get; set; }
		public Location Location { get; set; }
		public ICollection<Borrow> Borrows { get; set; }
		public enum BookStatus
		{
			Mevcut = 0,
			OduncVerildi = 1,
			GecikmisIade = 2
		}
	}
}
