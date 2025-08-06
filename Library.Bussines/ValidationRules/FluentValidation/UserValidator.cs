using FluentValidation;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bussines.ValidationRules.FluentValidation
{
	public class UserValidator : AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(u => u.UserName)
				.NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");

			RuleFor(u => u.Password)
				.NotEmpty().WithMessage("Şifre boş olamaz.")
				.MinimumLength(8).WithMessage("Şifre Uzunluğu 8 Karekterden uzun olmalı")
				.Must(p => !p.Contains(" ")).WithMessage("Şifre boşluk içeremez."); ;
			RuleFor(u => u.Email)
				.NotEmpty().WithMessage("E-posta boş olamaz.")
				.EmailAddress().WithMessage("Geçerli bir e-posta giriniz.");
			RuleFor(u => u.PhoneNumber)
				.NotEmpty().WithMessage("Telefon numarası boş olamaz.")
				.Length(11).WithMessage("Telefon Numarası Geçersiz")
				.Must(p => !p.Contains(" ")).WithMessage("Telefon numarası boşluk içeremez."); ;

			RuleFor(u => u.Role)
				.NotEmpty().WithMessage("Rol seçimi zorunludur.")
				.Must(r => r != "Kullanıcı Tipi") // varsayılan gibi görünmesin
				.WithMessage("Geçerli bir rol seçiniz.");
		}
	}
}
