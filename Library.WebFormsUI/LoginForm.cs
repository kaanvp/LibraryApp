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
				// �ifre g�ster
				siticoneTextbox2.IsPassword = false;
				pictureBox2.Image = Image.FromFile(@"C:\Users\vural\source\repos\LibraryManagementSystem\Library.WebFormsUI\Assets\Eye.png");
			}
			else
			{
				// �ifre gizle
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
				MessageBox.Show("Kullan�c� ad� ve �ifre alanlar� bo� b�rak�lamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string selectedRole = comboBox1.SelectedItem.ToString(); // �rnek: "Admin" veya "User"
			using (var context = new LibraryContext(new DbContextOptions<LibraryContext>()))
			{
				var user = context.Users
				.FirstOrDefault(u =>
					(u.UserName == siticoneTextbox1.Text || u.Email == siticoneTextbox1.Text)
					&& u.Password == siticoneTextbox2.Text);
				Session.CurrentUser = user;
				if (user != null)
				{
					// Kullan�c� bulundu, giri� ba�ar�l�
					var message = new MessageFrm("Giri� Ba�ar�l�");
					message.TopMost = true;
					message.Show();
					MainForm mainForm = new MainForm(selectedRole);
					mainForm.Show();
					this.Hide();
				}
				else
				{
					// Kullan�c� bulunamad�, giri� ba�ar�s�z
					MessageBox.Show("Kullan�c� ad� veya �ifre yanl��!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
