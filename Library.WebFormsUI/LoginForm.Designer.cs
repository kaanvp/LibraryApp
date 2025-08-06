namespace Library.WebFormsUI
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			pictureBox1 = new PictureBox();
			siticoneTextbox1 = new SiticoneWinFormsUI.SiticoneTextbox();
			siticoneTextbox2 = new SiticoneWinFormsUI.SiticoneTextbox();
			siticoneFilledButton1 = new SiticoneWinFormsUI.SiticoneFilledButton();
			CloseBtn = new Button();
			pictureBox2 = new PictureBox();
			comboBox1 = new ComboBox();
			pictureBox3 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.FromArgb(33, 57, 81);
			pictureBox1.Dock = DockStyle.Top;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(602, 65);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// siticoneTextbox1
			// 
			siticoneTextbox1.AlwaysRadial = false;
			siticoneTextbox1.AutoRadial = true;
			siticoneTextbox1.BorderColorOne = Color.FromArgb(170, 164, 213);
			siticoneTextbox1.BorderColorTwo = Color.FromArgb(170, 164, 213);
			siticoneTextbox1.BorderRadiusLowerLeft = true;
			siticoneTextbox1.BorderRadiusLowerRight = true;
			siticoneTextbox1.BorderRadiusUpperLeft = true;
			siticoneTextbox1.BorderRadiusUpperRight = true;
			siticoneTextbox1.BorderThickness = 1;
			siticoneTextbox1.ControlBackColor = Color.FromArgb(255, 255, 255);
			siticoneTextbox1.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneTextbox1.EnableRightToLeft = false;
			siticoneTextbox1.ErrorColor = Color.Red;
			siticoneTextbox1.IsPassword = false;
			siticoneTextbox1.IsReadonly = false;
			siticoneTextbox1.IsRequired = false;
			siticoneTextbox1.Location = new Point(144, 340);
			siticoneTextbox1.MakeLowercase = false;
			siticoneTextbox1.MakeUppercase = false;
			siticoneTextbox1.MinimumSize = new Size(150, 30);
			siticoneTextbox1.Name = "siticoneTextbox1";
			siticoneTextbox1.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			siticoneTextbox1.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			siticoneTextbox1.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			siticoneTextbox1.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			siticoneTextbox1.PlaceholderText = "Kullanıcı Adı veya E-mail";
			siticoneTextbox1.Radius = 22;
			siticoneTextbox1.RightToLeft = RightToLeft.No;
			siticoneTextbox1.ShowPasswordOnFocus = false;
			siticoneTextbox1.Size = new Size(300, 44);
			siticoneTextbox1.TabIndex = 3;
			siticoneTextbox1.TextColor = Color.Black;
			siticoneTextbox1.TrimStartEndSpaces = false;
			// 
			// siticoneTextbox2
			// 
			siticoneTextbox2.AlwaysRadial = true;
			siticoneTextbox2.AutoRadial = true;
			siticoneTextbox2.BorderColorOne = Color.FromArgb(170, 164, 213);
			siticoneTextbox2.BorderColorTwo = Color.FromArgb(170, 164, 213);
			siticoneTextbox2.BorderRadiusLowerLeft = true;
			siticoneTextbox2.BorderRadiusLowerRight = true;
			siticoneTextbox2.BorderRadiusUpperLeft = true;
			siticoneTextbox2.BorderRadiusUpperRight = true;
			siticoneTextbox2.BorderThickness = 1;
			siticoneTextbox2.ControlBackColor = Color.FromArgb(255, 255, 255);
			siticoneTextbox2.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneTextbox2.EnableRightToLeft = false;
			siticoneTextbox2.ErrorColor = Color.Red;
			siticoneTextbox2.IsPassword = true;
			siticoneTextbox2.IsReadonly = false;
			siticoneTextbox2.IsRequired = false;
			siticoneTextbox2.Location = new Point(144, 402);
			siticoneTextbox2.MakeLowercase = false;
			siticoneTextbox2.MakeUppercase = false;
			siticoneTextbox2.MinimumSize = new Size(150, 30);
			siticoneTextbox2.Name = "siticoneTextbox2";
			siticoneTextbox2.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			siticoneTextbox2.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			siticoneTextbox2.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			siticoneTextbox2.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			siticoneTextbox2.PlaceholderText = "Şifre";
			siticoneTextbox2.Radius = 22;
			siticoneTextbox2.RightToLeft = RightToLeft.No;
			siticoneTextbox2.ShowPasswordOnFocus = false;
			siticoneTextbox2.Size = new Size(300, 44);
			siticoneTextbox2.TabIndex = 4;
			siticoneTextbox2.TextColor = Color.Black;
			siticoneTextbox2.TrimStartEndSpaces = false;
			siticoneTextbox2.TextChanged += siticoneTextbox2_TextChanged;
			// 
			// siticoneFilledButton1
			// 
			siticoneFilledButton1.BackColor = Color.Transparent;
			siticoneFilledButton1.BorderColor = Color.FromArgb(33, 57, 81);
			siticoneFilledButton1.BorderColorOnButtonPress = Color.FromArgb(33, 57, 81);
			siticoneFilledButton1.BorderColorOnHover = Color.FromArgb(33, 57, 81);
			siticoneFilledButton1.BorderRadiusAllRound = 25;
			siticoneFilledButton1.BorderRadiusLowerLeft = true;
			siticoneFilledButton1.BorderRadiusLowerRight = true;
			siticoneFilledButton1.BorderRadiusUpperLeft = true;
			siticoneFilledButton1.BorderRadiusUpperRight = true;
			siticoneFilledButton1.BorderThickness = 2;
			siticoneFilledButton1.ClickEffect = true;
			siticoneFilledButton1.ControlBackColor = Color.FromArgb(33, 57, 81);
			siticoneFilledButton1.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			siticoneFilledButton1.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			siticoneFilledButton1.DialogResult = DialogResult.None;
			siticoneFilledButton1.ErrorColor = Color.FromArgb(220, 53, 69);
			siticoneFilledButton1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
			siticoneFilledButton1.ForeColor = Color.FromArgb(255, 255, 255);
			siticoneFilledButton1.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			siticoneFilledButton1.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			siticoneFilledButton1.HoverEffect = true;
			siticoneFilledButton1.Icon = null;
			siticoneFilledButton1.IconPaddingX = 0;
			siticoneFilledButton1.IconPaddingY = 0;
			siticoneFilledButton1.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			siticoneFilledButton1.ImeMode = ImeMode.NoControl;
			siticoneFilledButton1.IsBusy = false;
			siticoneFilledButton1.IsBusyText = "Busy, wait...";
			siticoneFilledButton1.Location = new Point(190, 508);
			siticoneFilledButton1.MinimumSize = new Size(100, 40);
			siticoneFilledButton1.Name = "siticoneFilledButton1";
			siticoneFilledButton1.RaiseError = false;
			siticoneFilledButton1.Size = new Size(225, 62);
			siticoneFilledButton1.TabIndex = 6;
			siticoneFilledButton1.Text = "GİRİŞ";
			siticoneFilledButton1.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneFilledButton1.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneFilledButton1.Click += siticoneFilledButton1_Click;
			// 
			// CloseBtn
			// 
			CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			CloseBtn.BackColor = Color.FromArgb(33, 57, 81);
			CloseBtn.FlatAppearance.BorderSize = 0;
			CloseBtn.FlatStyle = FlatStyle.Flat;
			CloseBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			CloseBtn.ForeColor = Color.White;
			CloseBtn.Location = new Point(553, 0);
			CloseBtn.Name = "CloseBtn";
			CloseBtn.Size = new Size(49, 36);
			CloseBtn.TabIndex = 7;
			CloseBtn.Text = "X";
			CloseBtn.UseVisualStyleBackColor = false;
			CloseBtn.Click += CloseBtn_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(453, 407);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(33, 31);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 8;
			pictureBox2.TabStop = false;
			pictureBox2.Visible = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// comboBox1
			// 
			comboBox1.FlatStyle = FlatStyle.Flat;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "admin\t", "kullanıcı" });
			comboBox1.Location = new Point(293, 465);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 28);
			comboBox1.TabIndex = 9;
			comboBox1.Text = "Kullanıcı Tipi";
			// 
			// pictureBox3
			// 
			pictureBox3.BackColor = Color.Transparent;
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(114, 67);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(347, 232);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 10;
			pictureBox3.TabStop = false;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gainsboro;
			ClientSize = new Size(602, 591);
			Controls.Add(pictureBox3);
			Controls.Add(comboBox1);
			Controls.Add(pictureBox2);
			Controls.Add(CloseBtn);
			Controls.Add(siticoneFilledButton1);
			Controls.Add(siticoneTextbox2);
			Controls.Add(siticoneTextbox1);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			Load += LoginForm_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private SiticoneWinFormsUI.SiticoneTextbox siticoneTextbox1;
		private SiticoneWinFormsUI.SiticoneTextbox siticoneTextbox2;
		private SiticoneWinFormsUI.SiticoneFilledButton siticoneFilledButton1;
		private Button CloseBtn;
		private PictureBox pictureBox2;
		private ComboBox comboBox1;
		private PictureBox pictureBox3;
	}
}
