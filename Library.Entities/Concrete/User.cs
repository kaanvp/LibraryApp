using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Role { get; set; } // Örnek: "Admin", "User", "Librarian"
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		public ICollection<Borrow> Borrows { get; set; }
	}
}
