using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class Location
	{
		public int Id { get; set; }
		public string Shelf { get; set; }         // Raf
		public string Row { get; set; }           // Sıra
		public string Position { get; set; }      // Konum açıklaması (örnek: "Sol Alt")

		public string FullLocation
		{
			get { return $"{Shelf} - {Row} - {Position}"; }
		}
		public ICollection<Book> Books { get; set; }
	}
}
