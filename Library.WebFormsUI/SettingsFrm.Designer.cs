namespace Library.WebFormsUI
{
	partial class SettingsFrm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label2 = new Label();
			maxBorrowedBooks = new ReaLTaiizor.Controls.ForeverNumeric();
			borrowDurationDays = new ReaLTaiizor.Controls.ForeverNumeric();
			lateFeePerDay = new ReaLTaiizor.Controls.ForeverNumeric();
			extensionPeriodDays = new ReaLTaiizor.Controls.ForeverNumeric();
			label1 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			dataGridView1 = new DataGridView();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.FromArgb(27, 46, 61);
			label2.Location = new Point(32, 9);
			label2.Name = "label2";
			label2.Size = new Size(223, 34);
			label2.TabIndex = 4;
			label2.Text = "Ödünç Ayarları";
			// 
			// maxBorrowedBooks
			// 
			maxBorrowedBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			maxBorrowedBooks.BaseColor = Color.White;
			maxBorrowedBooks.ButtonColorA = Color.FromArgb(27, 46, 61);
			maxBorrowedBooks.ButtonColorB = Color.White;
			maxBorrowedBooks.ButtonColorC = Color.White;
			maxBorrowedBooks.Font = new Font("Segoe UI", 10F);
			maxBorrowedBooks.ForeColor = Color.Black;
			maxBorrowedBooks.Location = new Point(53, 104);
			maxBorrowedBooks.Maximum = 100L;
			maxBorrowedBooks.Minimum = 0L;
			maxBorrowedBooks.Name = "maxBorrowedBooks";
			maxBorrowedBooks.Size = new Size(215, 30);
			maxBorrowedBooks.TabIndex = 9;
			maxBorrowedBooks.Text = "foreverNumeric1";
			maxBorrowedBooks.Value = 0L;
			// 
			// borrowDurationDays
			// 
			borrowDurationDays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			borrowDurationDays.BaseColor = Color.White;
			borrowDurationDays.ButtonColorA = Color.FromArgb(27, 46, 61);
			borrowDurationDays.ButtonColorB = Color.White;
			borrowDurationDays.ButtonColorC = Color.White;
			borrowDurationDays.Font = new Font("Segoe UI", 10F);
			borrowDurationDays.ForeColor = Color.Black;
			borrowDurationDays.Location = new Point(308, 104);
			borrowDurationDays.Maximum = 100L;
			borrowDurationDays.Minimum = 0L;
			borrowDurationDays.Name = "borrowDurationDays";
			borrowDurationDays.Size = new Size(215, 30);
			borrowDurationDays.TabIndex = 10;
			borrowDurationDays.Text = "foreverNumeric2";
			borrowDurationDays.Value = 0L;
			// 
			// lateFeePerDay
			// 
			lateFeePerDay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			lateFeePerDay.BaseColor = Color.White;
			lateFeePerDay.ButtonColorA = Color.FromArgb(27, 46, 61);
			lateFeePerDay.ButtonColorB = Color.White;
			lateFeePerDay.ButtonColorC = Color.White;
			lateFeePerDay.Font = new Font("Segoe UI", 10F);
			lateFeePerDay.ForeColor = Color.Black;
			lateFeePerDay.Location = new Point(791, 104);
			lateFeePerDay.Maximum = 100L;
			lateFeePerDay.Minimum = 0L;
			lateFeePerDay.Name = "lateFeePerDay";
			lateFeePerDay.Size = new Size(215, 30);
			lateFeePerDay.TabIndex = 11;
			lateFeePerDay.Text = "foreverNumeric3";
			lateFeePerDay.Value = 0L;
			// 
			// extensionPeriodDays
			// 
			extensionPeriodDays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			extensionPeriodDays.BaseColor = Color.White;
			extensionPeriodDays.ButtonColorA = Color.FromArgb(27, 46, 61);
			extensionPeriodDays.ButtonColorB = Color.White;
			extensionPeriodDays.ButtonColorC = Color.White;
			extensionPeriodDays.Font = new Font("Segoe UI", 10F);
			extensionPeriodDays.ForeColor = Color.Black;
			extensionPeriodDays.Location = new Point(549, 104);
			extensionPeriodDays.Maximum = 100L;
			extensionPeriodDays.Minimum = 0L;
			extensionPeriodDays.Name = "extensionPeriodDays";
			extensionPeriodDays.Size = new Size(215, 30);
			extensionPeriodDays.TabIndex = 12;
			extensionPeriodDays.Text = "foreverNumeric4";
			extensionPeriodDays.Value = 0L;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.ForeColor = Color.DimGray;
			label1.Location = new Point(32, 77);
			label1.Name = "label1";
			label1.Size = new Size(263, 24);
			label1.TabIndex = 13;
			label1.Text = "Maksimum Ödünç Kitap Sayısı";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			label3.AutoSize = true;
			label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.ForeColor = Color.DimGray;
			label3.Location = new Point(329, 77);
			label3.Name = "label3";
			label3.Size = new Size(172, 24);
			label3.TabIndex = 14;
			label3.Text = "Ödünç Süresi (Gün)";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			label4.AutoSize = true;
			label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label4.ForeColor = Color.DimGray;
			label4.Location = new Point(565, 77);
			label4.Name = "label4";
			label4.Size = new Size(181, 24);
			label4.TabIndex = 15;
			label4.Text = "Uzatma Süresi (Gün)";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			label5.AutoSize = true;
			label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label5.ForeColor = Color.DimGray;
			label5.Location = new Point(791, 77);
			label5.Name = "label5";
			label5.Size = new Size(218, 24);
			label5.TabIndex = 16;
			label5.Text = "Gecikme Cezası (TL/Gün)";
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(32, 227);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(977, 356);
			dataGridView1.TabIndex = 17;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label6.ForeColor = Color.FromArgb(27, 46, 61);
			label6.Location = new Point(32, 180);
			label6.Name = "label6";
			label6.Size = new Size(221, 34);
			label6.TabIndex = 18;
			label6.Text = "İşlem Kayıtları";
			// 
			// SettingsFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1135, 645);
			Controls.Add(label6);
			Controls.Add(dataGridView1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(extensionPeriodDays);
			Controls.Add(lateFeePerDay);
			Controls.Add(borrowDurationDays);
			Controls.Add(maxBorrowedBooks);
			Controls.Add(label2);
			FormBorderStyle = FormBorderStyle.None;
			Name = "SettingsFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SettingsFrm";
			Load += SettingsFrm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private ReaLTaiizor.Controls.ForeverNumeric maxBorrowedBooks;
		private ReaLTaiizor.Controls.ForeverNumeric borrowDurationDays;
		private ReaLTaiizor.Controls.ForeverNumeric lateFeePerDay;
		private ReaLTaiizor.Controls.ForeverNumeric extensionPeriodDays;
		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private DataGridView dataGridView1;
		private Label label6;
	}
}