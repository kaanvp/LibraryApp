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
	public partial class ManageUserFrm : Form
	{
		private Library.Bussines.Managers.UserManager _userManager;
		public ManageUserFrm()
		{
			InitializeComponent();
			_userManager = new UserManager();
		}

		private void UserManageFrm_Load(object sender, EventArgs e)
		{
			UtilitiesClass.DatagridviewStyle(dataGridView1);
			RefreshDataGridView(dataGridView1);
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AddBookBtn_Click(object sender, EventArgs e)
		{
			UtilitiesClass.BlurBackground(new AddUserFrm(), this);

		}

		private void UpdateBookBtn_Click(object sender, EventArgs e)
		{
			UtilitiesClass.BlurBackground(new UpdateUserFrm(), this);
		}

		private void RefreshBtn_Click(object sender, EventArgs e)
		{
			RefreshDataGridView(dataGridView1);
		}
		private void RefreshDataGridView(DataGridView dgv)
		{
			dgv.DataSource = _userManager.GetAll();
			dgv.Columns["Borrows"].Visible = false;
			dgv.Columns["UserId"].Visible = false;
			dgv.Columns["UserName"].HeaderText = "Kullanıcı Adı";
			dgv.Columns["Password"].HeaderText = "Şifre";
			dgv.Columns["Role"].HeaderText = "Kullanıcı Rolü";
			dgv.Columns["PhoneNumber"].HeaderText = "Telefon Numarası";
			dgv.Columns["Email"].HeaderText = "E-mail";
		}

		private void SearchTbx_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _userManager.GetAll()
				.Where(u => u.UserName.ToLower().Contains(SearchTbx.Text.ToLower()) ||
							u.Role.ToLower().Contains(SearchTbx.Text.ToLower()) ||
							u.PhoneNumber.Contains(SearchTbx.Text) ||
							u.Email.ToLower().Contains(SearchTbx.Text.ToLower()))
				.ToList();
		}

		private void DeleteBookBtn_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				var confirmResult = MessageBox.Show("Seçilen Kişiyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmResult == DialogResult.No)
				{
					return; // Kullanıcı silmeyi iptal etti
				}
				else if (confirmResult == DialogResult.Yes)
				{
					// Silme işlemi

					_userManager.Delete(
						new Library.Entities.Concrete.User
						{
							UserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserId"].Value)
						}
					);
					RefreshDataGridView(dataGridView1);
					MessageBox.Show("Kişi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			else
			{
				MessageBox.Show("Silmek için bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
