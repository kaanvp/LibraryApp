using Library.DataAccess.Context;
using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Library.WebFormsUI
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			if (siticoneTextbox2.Text != "")
			{
				pictureBox2.Visible = true;
			}
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private bool isPasswordVisible = false;
		private void pictureBox2_Click(object sender, EventArgs e)
		{

			isPasswordVisible = !isPasswordVisible;

			if (isPasswordVisible)
			{
				// Þifre göster
				siticoneTextbox2.IsPassword = false;
				pictureBox2.Image = Image.FromFile(@"C:\Users\vural\source\repos\LibraryManagementSystem\Library.WebFormsUI\Assets\Eye.png");
			}
			else
			{
				// Þifre gizle
				siticoneTextbox2.IsPassword = true;
				pictureBox2.Image = Image.FromFile(@"C:\Users\vural\source\repos\LibraryManagementSystem\Library.WebFormsUI\Assets\Invisible.png");
			}
		}

		private void siticoneTextbox2_TextChanged(object sender, EventArgs e)
		{
			if (siticoneTextbox2.Text != "")
			{
				pictureBox2.Visible = true;
			}
			else
			{
				pictureBox2.Visible = false;
			}
		}

		private void siticoneFilledButton1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(siticoneTextbox1.Text) || string.IsNullOrEmpty(siticoneTextbox2.Text) || comboBox1.SelectedItem == null)
			{
				MessageBox.Show("Kullanýcý adý ve þifre alanlarý boþ býrakýlamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string selectedRole = comboBox1.SelectedItem.ToString(); // örnek: "Admin" veya "User"
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				var user = context.Users
				.FirstOrDefault(u =>
					(u.UserName == siticoneTextbox1.Text || u.Email == siticoneTextbox1.Text)
					&& u.Password == siticoneTextbox2.Text);
				Session.CurrentUser = user;
				if (user != null)
				{
					// Kullanýcý bulundu, giriþ baþarýlý
					var message = new MessageFrm("Giriþ Baþarýlý");
					message.TopMost = true;
					message.Show();
					MainForm mainForm = new MainForm(selectedRole);
					mainForm.Show();
					this.Hide();
				}
				else
				{
					// Kullanýcý bulunamadý, giriþ baþarýsýz
					MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
