using FluentValidation;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bussines.ValidationRules.FluentValidation
{
	public class BookValidator : AbstractValidator<Book>
	{
		public BookValidator()
		{
			RuleFor(b => b.Title).NotEmpty().WithMessage("Kitap Adı boş olamaz");
			RuleFor(b => b.AuthorId).NotEmpty().WithMessage("Author ID boş olamaz.");
			RuleFor(b => b.CategoryId).NotEmpty().WithMessage("Kategori ID boş olamaz.");
			RuleFor(b => b.LocationId).NotEmpty().WithMessage("Konum ID boş olamaz.");
			RuleFor(b => b.ISBN).NotEmpty().WithMessage("ISBN boş olamaz");
			RuleFor(b => b.Status)
				.IsInEnum()
				.WithMessage("Geçersiz kitap durumu. Mevcut, Ödünç Verildi veya Gecikmiş İade olmalıdır.");

		}
	}
	
	
}
