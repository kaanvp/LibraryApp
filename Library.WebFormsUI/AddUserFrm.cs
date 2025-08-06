using Library.Bussines.Managers;
using Library.Bussines.ValidationRules.FluentValidation;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUI
{

	public partial class AddUserFrm : Form
	{
		private readonly UserValidator _userValidator;
		private readonly UserManager _userManager;
		public AddUserFrm()
		{
			InitializeComponent();
			_userManager = new UserManager();
			_userValidator = new UserValidator();
			RoleCbx.SelectedIndex = 0;
			
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{

			var user = new User
			{
				UserName = UserNameTbx.Text,
				Password = PasswordTbx.Text,
				Email = EmailTbx.Text,
				PhoneNumber = PhoneNoTbx.Text,
				Role = RoleCbx.Text
			};
			var validation = _userValidator.Validate(user);
			if (!validation.IsValid)
			{
				var errorMessage = string.Join(Environment.NewLine, validation.Errors.Select(e => e.ErrorMessage));
				var errorMessageFrm = new ErrorMessageFrm(errorMessage);
				errorMessageFrm.TopMost = true;
				errorMessageFrm.Show();
				return;
			}
			else
			{
				_userManager.Add(user);
				var message = new MessageFrm("Kullanıcı başarıyla eklendi.");
				message.TopMost = true;
				message.Show();
			}
		}
	}
}
