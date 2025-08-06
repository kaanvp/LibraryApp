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
	public partial class SettingsFrm : Form
	{
		private readonly TransactionLogManager transactionLogManager;
		public SettingsFrm()
		{
			InitializeComponent();
			transactionLogManager = new TransactionLogManager();
			// DataGridView stil ayarları
			UtilitiesClass.DatagridviewStyle(dataGridView1);
		}
		// 
		private void loadTransactionLogs()
		{
			try
			{
				var logs = transactionLogManager.GetAll();
				dataGridView1.DataSource = logs;

				// Sütun başlıklarını düzenle
				dataGridView1.Columns["Id"].HeaderText = "ID";
				dataGridView1.Columns["BookId"].HeaderText = "Kitap ID";
				dataGridView1.Columns["UserId"].HeaderText = "Kullanıcı ID";
				dataGridView1.Columns["BookTitle"].HeaderText = "Kitap Adı";
				dataGridView1.Columns["UserName"].HeaderText = "Kullanıcı Adı";
				dataGridView1.Columns["TransactionDate"].HeaderText = "İşlem Tarihi";
				dataGridView1.Columns["TransactionType"].HeaderText = "İşlem Türü";
				dataGridView1.Columns["DueDate"].HeaderText = "Son Tarih";
				dataGridView1.Columns["ReturnDate"].HeaderText = "İade Tarihi";
				dataGridView1.Columns["Status"].HeaderText = "Durum";
				dataGridView1.Columns["LateFee"].HeaderText = "Gecikme Ücreti";
				dataGridView1.Columns["LateFee"].DefaultCellStyle.Format = "C2";
				// Bazı sütunları gizle
				dataGridView1.Columns["BookId"].Visible = false;
				dataGridView1.Columns["UserId"].Visible = false;

				// Tarihleri formatla
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if (row.Cells["TransactionDate"].Value != null)
						row.Cells["TransactionDate"].Value = ((DateTime)row.Cells["TransactionDate"].Value).ToString("dd/MM/yyyy HH:mm");

					if (row.Cells["DueDate"].Value != null && row.Cells["DueDate"].Value != DBNull.Value)
						row.Cells["DueDate"].Value = ((DateTime)row.Cells["DueDate"].Value).ToString("dd/MM/yyyy");

					if (row.Cells["ReturnDate"].Value != null && row.Cells["ReturnDate"].Value != DBNull.Value)
						row.Cells["ReturnDate"].Value = ((DateTime)row.Cells["ReturnDate"].Value).ToString("dd/MM/yyyy");
				}
				// DataGridView stil ayarları
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dataGridView1.RowHeadersVisible = false;
				dataGridView1.AllowUserToAddRows = false;
				dataGridView1.ReadOnly = true;
				dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			}
			catch (Exception ex)
			{
				MessageBox.Show("İşlem kayıtları yüklenirken bir hata oluştu: " + ex.Message,
					"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void SettingsFrm_Load(object sender, EventArgs e)
		{
			loadTransactionLogs();
			maxBorrowedBooks.Value = UtilitiesClass._maxBorrowedBooks;
			borrowDurationDays.Value = UtilitiesClass._borrowDurationDays;
			extensionPeriodDays.Value = UtilitiesClass._extensionPeriodDays;
			lateFeePerDay.Value = UtilitiesClass._lateFeePerDay;
		}
	}

}
