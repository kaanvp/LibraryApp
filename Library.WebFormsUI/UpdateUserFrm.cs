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

	public partial class UpdateUserFrm : Form
	{
		private readonly UserManager _userManager;

		public UpdateUserFrm()
		{
			InitializeComponent();
			_userManager = new UserManager();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				UserNameTbx.Text = dataGridView1.CurrentRow.Cells["UserName"].Value?.ToString();
				PassTbx.Text = dataGridView1.CurrentRow.Cells["Password"].Value?.ToString();
				RoleCbx.Text = dataGridView1.CurrentRow.Cells["Role"].Value?.ToString();
				PhoneNoTbx.Text = dataGridView1.CurrentRow.Cells["PhoneNumber"].Value?.ToString();
				EmailTbx.Text = dataGridView1.CurrentRow.Cells["Email"].Value?.ToString();
			}


		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			try
			{
				int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserId"].Value);
				var existingUser = _userManager.GetById(bookId);
				if (existingUser == null)
				{
					MessageBox.Show("Kitap bulunamadı!");
					return;
				}
				existingUser.UserName = UserNameTbx.Text;
				existingUser.Password = PassTbx.Text;
				existingUser.Role = RoleCbx.Text;
				existingUser.PhoneNumber = PhoneNoTbx.Text;
				existingUser.Email = EmailTbx.Text;
				_userManager.Update(existingUser);
				var message = new MessageFrm("Kullanıcı Başarıyla Güncellendi");
				message.TopMost = true;
				message.Show(); dataGridView1.DataSource = _userManager.GetAll();
				RefreshDataGridView(dataGridView1);
			}
			catch
			{
				MessageBox.Show("Hata oluştu. Lütfen bilgileri kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void RefreshDataGridView(DataGridView dgv)
		{
			dataGridView1.Columns["UserId"].Visible = false; // Id sütununu gizle
			dataGridView1.Columns["Borrows"].Visible = false; // Borrows sütununu gizle
			dataGridView1.Columns["UserName"].HeaderText = "Kullanıcı Adı";
			dataGridView1.Columns["Password"].HeaderText = "Şifre";
			dataGridView1.Columns["Role"].HeaderText = "Kullanıcı Türü";
			dataGridView1.Columns["PhoneNumber"].HeaderText = "Telefon Numarası";
			dataGridView1.Columns["Email"].HeaderText = "E-posta";
			dataGridView1.VirtualMode = true;
		}
		private void UpdateUserFrm_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _userManager.GetAll();

			RefreshDataGridView(dataGridView1);
			UtilitiesClass.DatagridviewStyle(dataGridView1);
		}

		private void SearchTbx_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _userManager.GetAll()
				.Where(u => u.UserName.ToLower().Contains(SearchTbx.Text.ToLower()) ||
						 u.Role.ToLower().Contains(SearchTbx.Text.ToLower()) ||
						 u.PhoneNumber.ToLower().Contains(SearchTbx.Text.ToLower()) ||
						 u.Email.ToLower().Contains(SearchTbx.Text.ToLower()))
				.ToList();
		}
	}
}
