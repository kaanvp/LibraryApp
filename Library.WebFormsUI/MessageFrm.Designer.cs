namespace Library.WebFormsUI
{
	partial class MessageFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageFrm));
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
			CloseBtn.Location = new Point(211, 338);
			CloseBtn.MinimumSize = new Size(100, 40);
			CloseBtn.Name = "CloseBtn";
			CloseBtn.RaiseError = false;
			CloseBtn.Size = new Size(165, 57);
			CloseBtn.TabIndex = 5;
			CloseBtn.Text = "OK";
			CloseBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CloseBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CloseBtn.Click += CloseBtn_Click;
			// 
			// Messagelbl
			// 
			Messagelbl.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Messagelbl.ForeColor = SystemColors.WindowFrame;
			Messagelbl.Location = new Point(12, 212);
			Messagelbl.Name = "Messagelbl";
			Messagelbl.Size = new Size(556, 90);
			Messagelbl.TabIndex = 4;
			Messagelbl.Text = "İşlem Başarılı";
			Messagelbl.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// siticoneRadialPictureBox1
			// 
			siticoneRadialPictureBox1.BackColor = Color.Transparent;
			siticoneRadialPictureBox1.Image = (Image)resources.GetObject("siticoneRadialPictureBox1.Image");
			siticoneRadialPictureBox1.Location = new Point(174, 12);
			siticoneRadialPictureBox1.Name = "siticoneRadialPictureBox1";
			siticoneRadialPictureBox1.Size = new Size(232, 232);
			siticoneRadialPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			siticoneRadialPictureBox1.TabIndex = 3;
			siticoneRadialPictureBox1.TabStop = false;
			// 
			// MessageFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(580, 422);
			Controls.Add(CloseBtn);
			Controls.Add(Messagelbl);
			Controls.Add(siticoneRadialPictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MessageFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MessageFrm";
			((System.ComponentModel.ISupportInitialize)siticoneRadialPictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SiticoneWinFormsUI.SiticoneFilledButton CloseBtn;
		private Label Messagelbl;
		private SiticoneWinFormsUI.SiticoneRadialPictureBox siticoneRadialPictureBox1;
	}
}