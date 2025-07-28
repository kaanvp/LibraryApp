using Library.Bussines.Managers;
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
		private readonly UserManager _userManager;
		public AddUserFrm()
		{
			InitializeComponent();
			_userManager = new UserManager();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (RoleCbx.SelectedItem == null)
			{
				MessageBox.Show("Lütfen bir rol seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			var user = new Library.Entities.Concrete.User
			{
				UserName = UserNameTbx.Text,
				Password = PasswordTbx.Text,
				Email = EmailTbx.Text,
				PhoneNumber = PhoneNoTbx.Text,
				Role = RoleCbx.SelectedItem.ToString()
			};
			_userManager.Add(user);
			var message = new MessageFrm("Kullanıcı başarıyla eklendi.");
			message.TopMost = true;
			message.Show();
		}
	}
}
