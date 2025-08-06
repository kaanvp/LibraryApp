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
			RuleFor(b => b.Title)
				.NotEmpty().WithMessage("Kitap adı boş olamaz.");


			RuleFor(b => b.AuthorId)
				.NotNull().WithMessage("Yazar seçilmelidir.")
				.GreaterThan(0).WithMessage("Yazar adı boş olamaz.");

			RuleFor(b => b.CategoryId)
				.NotNull().WithMessage("Kategori seçilmelidir.")
				.GreaterThan(0).WithMessage("Kategori adı boş olamaz");

			RuleFor(b => b.LocationId)
				.NotNull().WithMessage("Konum seçilmelidir.")
				.GreaterThan(0).WithMessage("Konum boş olamaz");

			RuleFor(b => b.ISBN)
				.NotEmpty().WithMessage("ISBN boş olamaz.");
		}
	}



}
