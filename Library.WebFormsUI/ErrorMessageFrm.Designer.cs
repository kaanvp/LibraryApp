namespace Library.WebFormsUI
{
	partial class ErrorMessageFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMessageFrm));
			CloseBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			Messagelbl = new Label();
			siticoneRadialPictureBox1 = new SiticoneWinFormsUI.SiticoneRadialPictureBox();
			((System.ComponentModel.ISupportInitialize)siticoneRadialPictureBox1).BeginInit();
			SuspendLayout();
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
			CloseBtn.Location = new Point(232, 415);
			CloseBtn.MinimumSize = new Size(100, 40);
			CloseBtn.Name = "CloseBtn";
			CloseBtn.RaiseError = false;
			CloseBtn.Size = new Size(165, 57);
			CloseBtn.TabIndex = 8;
			CloseBtn.Text = "OK";
			CloseBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CloseBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CloseBtn.Click += CloseBtn_Click;
			// 
			// Messagelbl
			// 
			Messagelbl.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
			Messagelbl.ForeColor = SystemColors.WindowFrame;
			Messagelbl.Location = new Point(12, 207);
			Messagelbl.Name = "Messagelbl";
			Messagelbl.Size = new Size(619, 205);
			Messagelbl.TabIndex = 7;
			Messagelbl.Text = "İşlem Başarılı";
			Messagelbl.TextAlign = ContentAlignment.TopCenter;
			// 
			// siticoneRadialPictureBox1
			// 
			siticoneRadialPictureBox1.BackColor = Color.Transparent;
			siticoneRadialPictureBox1.Image = (Image)resources.GetObject("siticoneRadialPictureBox1.Image");
			siticoneRadialPictureBox1.Location = new Point(231, 27);
			siticoneRadialPictureBox1.Name = "siticoneRadialPictureBox1";
			siticoneRadialPictureBox1.Size = new Size(173, 173);
			siticoneRadialPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			siticoneRadialPictureBox1.TabIndex = 6;
			siticoneRadialPictureBox1.TabStop = false;
			// 
			// ErrorMessageFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(631, 510);
			Controls.Add(CloseBtn);
			Controls.Add(Messagelbl);
			Controls.Add(siticoneRadialPictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ErrorMessageFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ErrorMessageForm";
			((System.ComponentModel.ISupportInitialize)siticoneRadialPictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SiticoneWinFormsUI.SiticoneFilledButton CloseBtn;
		private Label Messagelbl;
		private SiticoneWinFormsUI.SiticoneRadialPictureBox siticoneRadialPictureBox1;
	}
}