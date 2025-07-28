namespace Library.WebFormsUI
{
	partial class ucSuccesMessage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSuccesMessage));
			siticoneRadialPictureBox1 = new SiticoneWinFormsUI.SiticoneRadialPictureBox();
			label1 = new Label();
			CloseBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			((System.ComponentModel.ISupportInitialize)siticoneRadialPictureBox1).BeginInit();
			SuspendLayout();
			// 
			// siticoneRadialPictureBox1
			// 
			siticoneRadialPictureBox1.BackColor = Color.Transparent;
			siticoneRadialPictureBox1.Image = (Image)resources.GetObject("siticoneRadialPictureBox1.Image");
			siticoneRadialPictureBox1.Location = new Point(198, 0);
			siticoneRadialPictureBox1.Name = "siticoneRadialPictureBox1";
			siticoneRadialPictureBox1.Size = new Size(232, 232);
			siticoneRadialPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			siticoneRadialPictureBox1.TabIndex = 0;
			siticoneRadialPictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.WindowFrame;
			label1.Location = new Point(198, 212);
			label1.Name = "label1";
			label1.Size = new Size(235, 40);
			label1.TabIndex = 1;
			label1.Text = "İşlem Başarılı";
			// 
			// CloseBtn
			// 
			CloseBtn.BackColor = Color.Transparent;
			CloseBtn.BorderColor = Color.FromArgb(27, 46, 61);
			CloseBtn.BorderColorOnButtonPress = Color.FromArgb(27, 46, 61);
			CloseBtn.BorderColorOnHover = Color.FromArgb(27, 46, 61);
			CloseBtn.BorderRadiusAllRound = 5;
			CloseBtn.BorderRadiusLowerLeft = true;
			CloseBtn.BorderRadiusLowerRight = true;
			CloseBtn.BorderRadiusUpperLeft = true;
			CloseBtn.BorderRadiusUpperRight = true;
			CloseBtn.BorderThickness = 2;
			CloseBtn.ClickEffect = true;
			CloseBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			CloseBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			CloseBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			CloseBtn.DialogResult = DialogResult.None;
			CloseBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			CloseBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			CloseBtn.ForeColor = Color.FromArgb(255, 255, 255);
			CloseBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			CloseBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			CloseBtn.HoverEffect = true;
			CloseBtn.Icon = null;
			CloseBtn.IconPaddingX = 0;
			CloseBtn.IconPaddingY = 0;
			CloseBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			CloseBtn.IsBusy = false;
			CloseBtn.IsBusyText = "Busy, wait...";
			CloseBtn.Location = new Point(228, 284);
			CloseBtn.MinimumSize = new Size(100, 40);
			CloseBtn.Name = "CloseBtn";
			CloseBtn.RaiseError = false;
			CloseBtn.Size = new Size(165, 57);
			CloseBtn.TabIndex = 2;
			CloseBtn.Text = "OK";
			CloseBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CloseBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CloseBtn.Click += CloseBtn_Click;
			// 
			// ucSuccesMessage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(CloseBtn);
			Controls.Add(label1);
			Controls.Add(siticoneRadialPictureBox1);
			Name = "ucSuccesMessage";
			Size = new Size(591, 379);
			((System.ComponentModel.ISupportInitialize)siticoneRadialPictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private SiticoneWinFormsUI.SiticoneRadialPictureBox siticoneRadialPictureBox1;
		private Label label1;
		private SiticoneWinFormsUI.SiticoneFilledButton CloseBtn;
	}
}
