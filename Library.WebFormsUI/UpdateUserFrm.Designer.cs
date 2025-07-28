namespace Library.WebFormsUI
{
	partial class UpdateUserFrm
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
			dataGridView1 = new DataGridView();
			CloseBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			SaveBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			UserNameTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			panel1 = new Panel();
			PassTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			EmailTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			PhoneNoTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			RoleCbx = new ComboBox();
			SearchTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(347, 144);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(717, 421);
			dataGridView1.TabIndex = 28;
			dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
			// 
			// CloseBtn
			// 
			CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			CloseBtn.BackColor = Color.Transparent;
			CloseBtn.BorderColor = Color.Crimson;
			CloseBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			CloseBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			CloseBtn.BorderRadiusAllRound = 28;
			CloseBtn.BorderRadiusLowerLeft = true;
			CloseBtn.BorderRadiusLowerRight = true;
			CloseBtn.BorderRadiusUpperLeft = true;
			CloseBtn.BorderRadiusUpperRight = true;
			CloseBtn.BorderThickness = 2;
			CloseBtn.ClickEffect = true;
			CloseBtn.ControlBackColor = Color.Crimson;
			CloseBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			CloseBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			CloseBtn.DialogResult = DialogResult.None;
			CloseBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			CloseBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
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
			CloseBtn.Location = new Point(746, 575);
			CloseBtn.MinimumSize = new Size(100, 40);
			CloseBtn.Name = "CloseBtn";
			CloseBtn.RaiseError = false;
			CloseBtn.Size = new Size(209, 62);
			CloseBtn.TabIndex = 30;
			CloseBtn.Text = "Kapat";
			CloseBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CloseBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CloseBtn.Click += CloseBtn_Click;
			// 
			// SaveBtn
			// 
			SaveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			SaveBtn.BackColor = Color.Transparent;
			SaveBtn.BorderColor = Color.FromArgb(27, 46, 61);
			SaveBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			SaveBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			SaveBtn.BorderRadiusAllRound = 28;
			SaveBtn.BorderRadiusLowerLeft = true;
			SaveBtn.BorderRadiusLowerRight = true;
			SaveBtn.BorderRadiusUpperLeft = true;
			SaveBtn.BorderRadiusUpperRight = true;
			SaveBtn.BorderThickness = 2;
			SaveBtn.ClickEffect = true;
			SaveBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			SaveBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			SaveBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			SaveBtn.DialogResult = DialogResult.None;
			SaveBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			SaveBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			SaveBtn.ForeColor = Color.FromArgb(255, 255, 255);
			SaveBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			SaveBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			SaveBtn.HoverEffect = true;
			SaveBtn.Icon = null;
			SaveBtn.IconPaddingX = 0;
			SaveBtn.IconPaddingY = 0;
			SaveBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			SaveBtn.IsBusy = false;
			SaveBtn.IsBusyText = "Busy, wait...";
			SaveBtn.Location = new Point(501, 575);
			SaveBtn.MinimumSize = new Size(100, 40);
			SaveBtn.Name = "SaveBtn";
			SaveBtn.RaiseError = false;
			SaveBtn.Size = new Size(209, 62);
			SaveBtn.TabIndex = 29;
			SaveBtn.Text = "Kaydet";
			SaveBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			SaveBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			SaveBtn.Click += SaveBtn_Click;
			// 
			// UserNameTbx
			// 
			UserNameTbx.AlwaysRadial = true;
			UserNameTbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			UserNameTbx.AutoRadial = true;
			UserNameTbx.BorderColorOne = Color.FromArgb(170, 164, 213);
			UserNameTbx.BorderColorTwo = Color.FromArgb(170, 164, 213);
			UserNameTbx.BorderRadiusLowerLeft = true;
			UserNameTbx.BorderRadiusLowerRight = true;
			UserNameTbx.BorderRadiusUpperLeft = true;
			UserNameTbx.BorderRadiusUpperRight = true;
			UserNameTbx.BorderThickness = 1;
			UserNameTbx.ControlBackColor = Color.FromArgb(255, 255, 255);
			UserNameTbx.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			UserNameTbx.EnableRightToLeft = false;
			UserNameTbx.ErrorColor = Color.Red;
			UserNameTbx.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
			UserNameTbx.IsPassword = false;
			UserNameTbx.IsReadonly = false;
			UserNameTbx.IsRequired = false;
			UserNameTbx.Location = new Point(12, 144);
			UserNameTbx.MakeLowercase = false;
			UserNameTbx.MakeUppercase = false;
			UserNameTbx.MinimumSize = new Size(150, 30);
			UserNameTbx.Name = "UserNameTbx";
			UserNameTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			UserNameTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			UserNameTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			UserNameTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			UserNameTbx.PlaceholderText = "Kullanıcı Adı";
			UserNameTbx.Radius = 25;
			UserNameTbx.RightToLeft = RightToLeft.No;
			UserNameTbx.ShowPasswordOnFocus = false;
			UserNameTbx.Size = new Size(314, 51);
			UserNameTbx.TabIndex = 31;
			UserNameTbx.TextColor = Color.Black;
			UserNameTbx.TrimStartEndSpaces = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(33, 57, 81);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1076, 50);
			panel1.TabIndex = 32;
			// 
			// PassTbx
			// 
			PassTbx.AlwaysRadial = true;
			PassTbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			PassTbx.AutoRadial = true;
			PassTbx.BorderColorOne = Color.FromArgb(170, 164, 213);
			PassTbx.BorderColorTwo = Color.FromArgb(170, 164, 213);
			PassTbx.BorderRadiusLowerLeft = true;
			PassTbx.BorderRadiusLowerRight = true;
			PassTbx.BorderRadiusUpperLeft = true;
			PassTbx.BorderRadiusUpperRight = true;
			PassTbx.BorderThickness = 1;
			PassTbx.ControlBackColor = Color.FromArgb(255, 255, 255);
			PassTbx.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			PassTbx.EnableRightToLeft = false;
			PassTbx.ErrorColor = Color.Red;
			PassTbx.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
			PassTbx.IsPassword = false;
			PassTbx.IsReadonly = false;
			PassTbx.IsRequired = false;
			PassTbx.Location = new Point(12, 241);
			PassTbx.MakeLowercase = false;
			PassTbx.MakeUppercase = false;
			PassTbx.MinimumSize = new Size(150, 30);
			PassTbx.Name = "PassTbx";
			PassTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			PassTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			PassTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			PassTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			PassTbx.PlaceholderText = "Şifre";
			PassTbx.Radius = 25;
			PassTbx.RightToLeft = RightToLeft.No;
			PassTbx.ShowPasswordOnFocus = false;
			PassTbx.Size = new Size(314, 51);
			PassTbx.TabIndex = 33;
			PassTbx.TextColor = Color.Black;
			PassTbx.TrimStartEndSpaces = false;
			// 
			// EmailTbx
			// 
			EmailTbx.AlwaysRadial = true;
			EmailTbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			EmailTbx.AutoRadial = true;
			EmailTbx.BorderColorOne = Color.FromArgb(170, 164, 213);
			EmailTbx.BorderColorTwo = Color.FromArgb(170, 164, 213);
			EmailTbx.BorderRadiusLowerLeft = true;
			EmailTbx.BorderRadiusLowerRight = true;
			EmailTbx.BorderRadiusUpperLeft = true;
			EmailTbx.BorderRadiusUpperRight = true;
			EmailTbx.BorderThickness = 1;
			EmailTbx.ControlBackColor = Color.FromArgb(255, 255, 255);
			EmailTbx.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			EmailTbx.EnableRightToLeft = false;
			EmailTbx.ErrorColor = Color.Red;
			EmailTbx.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
			EmailTbx.IsPassword = false;
			EmailTbx.IsReadonly = false;
			EmailTbx.IsRequired = false;
			EmailTbx.Location = new Point(12, 346);
			EmailTbx.MakeLowercase = false;
			EmailTbx.MakeUppercase = false;
			EmailTbx.MinimumSize = new Size(150, 30);
			EmailTbx.Name = "EmailTbx";
			EmailTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			EmailTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			EmailTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			EmailTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			EmailTbx.PlaceholderText = "E-posta";
			EmailTbx.Radius = 25;
			EmailTbx.RightToLeft = RightToLeft.No;
			EmailTbx.ShowPasswordOnFocus = false;
			EmailTbx.Size = new Size(314, 51);
			EmailTbx.TabIndex = 34;
			EmailTbx.TextColor = Color.Black;
			EmailTbx.TrimStartEndSpaces = false;
			// 
			// PhoneNoTbx
			// 
			PhoneNoTbx.AlwaysRadial = true;
			PhoneNoTbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			PhoneNoTbx.AutoRadial = true;
			PhoneNoTbx.BorderColorOne = Color.FromArgb(170, 164, 213);
			PhoneNoTbx.BorderColorTwo = Color.FromArgb(170, 164, 213);
			PhoneNoTbx.BorderRadiusLowerLeft = true;
			PhoneNoTbx.BorderRadiusLowerRight = true;
			PhoneNoTbx.BorderRadiusUpperLeft = true;
			PhoneNoTbx.BorderRadiusUpperRight = true;
			PhoneNoTbx.BorderThickness = 1;
			PhoneNoTbx.ControlBackColor = Color.FromArgb(255, 255, 255);
			PhoneNoTbx.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			PhoneNoTbx.EnableRightToLeft = false;
			PhoneNoTbx.ErrorColor = Color.Red;
			PhoneNoTbx.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
			PhoneNoTbx.IsPassword = false;
			PhoneNoTbx.IsReadonly = false;
			PhoneNoTbx.IsRequired = false;
			PhoneNoTbx.Location = new Point(12, 442);
			PhoneNoTbx.MakeLowercase = false;
			PhoneNoTbx.MakeUppercase = false;
			PhoneNoTbx.MinimumSize = new Size(150, 30);
			PhoneNoTbx.Name = "PhoneNoTbx";
			PhoneNoTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			PhoneNoTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			PhoneNoTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			PhoneNoTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			PhoneNoTbx.PlaceholderText = "Telefon Numarası";
			PhoneNoTbx.Radius = 25;
			PhoneNoTbx.RightToLeft = RightToLeft.No;
			PhoneNoTbx.ShowPasswordOnFocus = false;
			PhoneNoTbx.Size = new Size(314, 51);
			PhoneNoTbx.TabIndex = 35;
			PhoneNoTbx.TextColor = Color.Black;
			PhoneNoTbx.TrimStartEndSpaces = false;
			// 
			// RoleCbx
			// 
			RoleCbx.FlatStyle = FlatStyle.Flat;
			RoleCbx.FormattingEnabled = true;
			RoleCbx.Items.AddRange(new object[] { "kullanıcı", "admin" });
			RoleCbx.Location = new Point(12, 537);
			RoleCbx.Name = "RoleCbx";
			RoleCbx.Size = new Size(291, 28);
			RoleCbx.TabIndex = 36;
			RoleCbx.Text = "Kullanıcı Türü";
			// 
			// SearchTbx
			// 
			SearchTbx.AlwaysRadial = true;
			SearchTbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			SearchTbx.AutoRadial = true;
			SearchTbx.BorderColorOne = Color.FromArgb(170, 164, 213);
			SearchTbx.BorderColorTwo = Color.FromArgb(170, 164, 213);
			SearchTbx.BorderRadiusLowerLeft = true;
			SearchTbx.BorderRadiusLowerRight = true;
			SearchTbx.BorderRadiusUpperLeft = true;
			SearchTbx.BorderRadiusUpperRight = true;
			SearchTbx.BorderThickness = 1;
			SearchTbx.ControlBackColor = Color.FromArgb(255, 255, 255);
			SearchTbx.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			SearchTbx.EnableRightToLeft = false;
			SearchTbx.ErrorColor = Color.Red;
			SearchTbx.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
			SearchTbx.IsPassword = false;
			SearchTbx.IsReadonly = false;
			SearchTbx.IsRequired = false;
			SearchTbx.Location = new Point(347, 81);
			SearchTbx.MakeLowercase = false;
			SearchTbx.MakeUppercase = false;
			SearchTbx.MinimumSize = new Size(150, 30);
			SearchTbx.Name = "SearchTbx";
			SearchTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			SearchTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			SearchTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			SearchTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			SearchTbx.PlaceholderText = "Aramak için Kullanıcı adı girin";
			SearchTbx.Radius = 25;
			SearchTbx.RightToLeft = RightToLeft.No;
			SearchTbx.ShowPasswordOnFocus = false;
			SearchTbx.Size = new Size(717, 51);
			SearchTbx.TabIndex = 37;
			SearchTbx.TextColor = Color.Black;
			SearchTbx.TrimStartEndSpaces = false;
			SearchTbx.TextChanged += SearchTbx_TextChanged;
			// 
			// UpdateUserFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1076, 649);
			Controls.Add(SearchTbx);
			Controls.Add(RoleCbx);
			Controls.Add(PhoneNoTbx);
			Controls.Add(EmailTbx);
			Controls.Add(PassTbx);
			Controls.Add(panel1);
			Controls.Add(UserNameTbx);
			Controls.Add(CloseBtn);
			Controls.Add(SaveBtn);
			Controls.Add(dataGridView1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "UpdateUserFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "UpdateUserFrm";
			Load += UpdateUserFrm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private SiticoneWinFormsUI.SiticoneFilledButton CloseBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton SaveBtn;
		private SiticoneWinFormsUI.SiticoneTextbox UserNameTbx;
		private Panel panel1;
		private SiticoneWinFormsUI.SiticoneTextbox PassTbx;
		private SiticoneWinFormsUI.SiticoneTextbox EmailTbx;
		private SiticoneWinFormsUI.SiticoneTextbox PhoneNoTbx;
		private ComboBox RoleCbx;
		private SiticoneWinFormsUI.SiticoneTextbox SearchTbx;
	}
}