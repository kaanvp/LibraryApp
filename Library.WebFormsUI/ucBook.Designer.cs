namespace Library.WebFormsUI
{
	partial class ucBook
	{
		/// <summary> 
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Bileşen Tasarımcısı üretimi kod

		/// <summary> 
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBook));
			AuthorNameuc = new Label();
			BookNameuc = new Label();
			Imageuc = new PictureBox();
			siticoneFlatPanel1 = new SiticoneWinFormsUI.SiticoneFlatPanel();
			((System.ComponentModel.ISupportInitialize)Imageuc).BeginInit();
			siticoneFlatPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// AuthorNameuc
			// 
			AuthorNameuc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
			AuthorNameuc.ForeColor = Color.DarkGray;
			AuthorNameuc.Location = new Point(0, 230);
			AuthorNameuc.Name = "AuthorNameuc";
			AuthorNameuc.Size = new Size(256, 34);
			AuthorNameuc.TabIndex = 7;
			AuthorNameuc.Text = "label2";
			AuthorNameuc.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BookNameuc
			// 
			BookNameuc.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			BookNameuc.ForeColor = Color.Black;
			BookNameuc.Location = new Point(0, 185);
			BookNameuc.Name = "BookNameuc";
			BookNameuc.Size = new Size(259, 34);
			BookNameuc.TabIndex = 6;
			BookNameuc.Text = "label1";
			BookNameuc.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Imageuc
			// 
			Imageuc.BackColor = Color.Transparent;
			Imageuc.Image = (Image)resources.GetObject("Imageuc.Image");
			Imageuc.Location = new Point(0, 7);
			Imageuc.Name = "Imageuc";
			Imageuc.Size = new Size(259, 175);
			Imageuc.SizeMode = PictureBoxSizeMode.Zoom;
			Imageuc.TabIndex = 5;
			Imageuc.TabStop = false;
			Imageuc.MouseEnter += Imageuc_MouseEnter;
			Imageuc.MouseLeave += Imageuc_MouseLeave;
			// 
			// siticoneFlatPanel1
			// 
			siticoneFlatPanel1.BackColor = Color.Transparent;
			siticoneFlatPanel1.BorderColorBottom = Color.FromArgb(33, 57, 81);
			siticoneFlatPanel1.BorderColorLeft = Color.LightGray;
			siticoneFlatPanel1.BorderColorRight = Color.LightGray;
			siticoneFlatPanel1.BorderColorTop = Color.LightGray;
			siticoneFlatPanel1.BorderStyleBottom = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneFlatPanel1.BorderStyleLeft = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneFlatPanel1.BorderStyleRight = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneFlatPanel1.BorderStyleTop = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneFlatPanel1.BorderThicknessBottom = 30;
			siticoneFlatPanel1.BorderThicknessLeft = 1;
			siticoneFlatPanel1.BorderThicknessRight = 1;
			siticoneFlatPanel1.BorderThicknessTop = 1;
			siticoneFlatPanel1.Controls.Add(AuthorNameuc);
			siticoneFlatPanel1.Controls.Add(Imageuc);
			siticoneFlatPanel1.Controls.Add(BookNameuc);
			siticoneFlatPanel1.Cursor = Cursors.Hand;
			siticoneFlatPanel1.Location = new Point(0, 0);
			siticoneFlatPanel1.MinimumSize = new Size(20, 20);
			siticoneFlatPanel1.Name = "siticoneFlatPanel1";
			siticoneFlatPanel1.Size = new Size(256, 286);
			siticoneFlatPanel1.TabIndex = 5;
			// 
			// ucBook
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			Controls.Add(siticoneFlatPanel1);
			Name = "ucBook";
			Size = new Size(259, 287);
			((System.ComponentModel.ISupportInitialize)Imageuc).EndInit();
			siticoneFlatPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private PictureBox Imageuc;
		private Label AuthorNameuc;
		private Label BookNameuc;
		private SiticoneWinFormsUI.SiticoneFlatPanel siticoneFlatPanel1;
	}
}
