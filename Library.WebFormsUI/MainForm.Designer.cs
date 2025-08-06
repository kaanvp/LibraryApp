namespace Library.WebFormsUI
{
	partial class MainForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			CloseBtn = new Button();
			siticoneRadialPanel1 = new SiticoneWinFormsUI.SiticoneRadialPanel();
			HomeFormBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			ManageBookBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			siticoneRadialPictureBox1 = new SiticoneWinFormsUI.SiticoneRadialPictureBox();
			SettingBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			ManageBorrowBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			ManageUserBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			panel1 = new Panel();
			label1 = new Label();
			button2 = new Button();
			button1 = new Button();
			CenterPanel = new Panel();
			label2 = new Label();
			MainPanel = new SiticoneWinFormsUI.SiticoneRadialFlowLayoutPanel();
			siticoneFilledButton1 = new SiticoneWinFormsUI.SiticoneFilledButton();
			SearchTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			OverdueCheckTimer = new System.Windows.Forms.Timer(components);
			siticoneRadialPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)siticoneRadialPictureBox1).BeginInit();
			panel1.SuspendLayout();
			CenterPanel.SuspendLayout();
			SuspendLayout();
			// 
			// CloseBtn
			// 
			CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			CloseBtn.BackColor = Color.FromArgb(33, 57, 81);
			CloseBtn.FlatAppearance.BorderSize = 0;
			CloseBtn.FlatStyle = FlatStyle.Flat;
			CloseBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			CloseBtn.ForeColor = Color.White;
			CloseBtn.Location = new Point(1375, 0);
			CloseBtn.Name = "CloseBtn";
			CloseBtn.Size = new Size(63, 41);
			CloseBtn.TabIndex = 8;
			CloseBtn.Text = "X";
			CloseBtn.UseVisualStyleBackColor = false;
			CloseBtn.Click += CloseBtn_Click;
			// 
			// siticoneRadialPanel1
			// 
			siticoneRadialPanel1.BackColor = Color.Transparent;
			siticoneRadialPanel1.BorderColor = Color.FromArgb(22, 32, 42);
			siticoneRadialPanel1.BorderRadiusLowerLeft = false;
			siticoneRadialPanel1.BorderRadiusLowerRight = false;
			siticoneRadialPanel1.BorderRadiusUpperLeft = false;
			siticoneRadialPanel1.BorderRadiusUpperRight = true;
			siticoneRadialPanel1.BorderThickness = 5;
			siticoneRadialPanel1.Controls.Add(HomeFormBtn);
			siticoneRadialPanel1.Controls.Add(ManageBookBtn);
			siticoneRadialPanel1.Controls.Add(siticoneRadialPictureBox1);
			siticoneRadialPanel1.Controls.Add(SettingBtn);
			siticoneRadialPanel1.Controls.Add(ManageBorrowBtn);
			siticoneRadialPanel1.Controls.Add(ManageUserBtn);
			siticoneRadialPanel1.Dock = DockStyle.Left;
			siticoneRadialPanel1.Location = new Point(0, 55);
			siticoneRadialPanel1.MinimumSize = new Size(20, 20);
			siticoneRadialPanel1.Name = "siticoneRadialPanel1";
			siticoneRadialPanel1.PanelBackColor = Color.FromArgb(22, 32, 42);
			siticoneRadialPanel1.Radius = 45;
			siticoneRadialPanel1.Size = new Size(226, 747);
			siticoneRadialPanel1.TabIndex = 9;
			siticoneRadialPanel1.VisualStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			// 
			// HomeFormBtn
			// 
			HomeFormBtn.BackColor = Color.Transparent;
			HomeFormBtn.BorderColor = Color.FromArgb(22, 32, 42);
			HomeFormBtn.BorderColorOnButtonPress = Color.FromArgb(22, 32, 42);
			HomeFormBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			HomeFormBtn.BorderRadiusAllRound = 1;
			HomeFormBtn.BorderRadiusLowerLeft = true;
			HomeFormBtn.BorderRadiusLowerRight = true;
			HomeFormBtn.BorderRadiusUpperLeft = true;
			HomeFormBtn.BorderRadiusUpperRight = true;
			HomeFormBtn.BorderThickness = 0;
			HomeFormBtn.ClickEffect = true;
			HomeFormBtn.ControlBackColor = Color.FromArgb(22, 32, 42);
			HomeFormBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			HomeFormBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			HomeFormBtn.DialogResult = DialogResult.None;
			HomeFormBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			HomeFormBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
			HomeFormBtn.ForeColor = Color.FromArgb(255, 255, 255);
			HomeFormBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			HomeFormBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			HomeFormBtn.HoverEffect = true;
			HomeFormBtn.Icon = (Image)resources.GetObject("HomeFormBtn.Icon");
			HomeFormBtn.IconPaddingX = 15;
			HomeFormBtn.IconPaddingY = 0;
			HomeFormBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			HomeFormBtn.IsBusy = false;
			HomeFormBtn.IsBusyText = "Busy, wait...";
			HomeFormBtn.Location = new Point(0, 131);
			HomeFormBtn.MinimumSize = new Size(100, 40);
			HomeFormBtn.Name = "HomeFormBtn";
			HomeFormBtn.RaiseError = false;
			HomeFormBtn.Size = new Size(226, 62);
			HomeFormBtn.TabIndex = 4;
			HomeFormBtn.Text = "Kitaplar";
			HomeFormBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			HomeFormBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			HomeFormBtn.Click += MainFormBtn_Click;
			// 
			// ManageBookBtn
			// 
			ManageBookBtn.BackColor = Color.Transparent;
			ManageBookBtn.BorderColor = Color.FromArgb(22, 32, 42);
			ManageBookBtn.BorderColorOnButtonPress = Color.FromArgb(22, 32, 42);
			ManageBookBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			ManageBookBtn.BorderRadiusAllRound = 1;
			ManageBookBtn.BorderRadiusLowerLeft = true;
			ManageBookBtn.BorderRadiusLowerRight = true;
			ManageBookBtn.BorderRadiusUpperLeft = true;
			ManageBookBtn.BorderRadiusUpperRight = true;
			ManageBookBtn.BorderThickness = 0;
			ManageBookBtn.ClickEffect = true;
			ManageBookBtn.ControlBackColor = Color.FromArgb(22, 32, 42);
			ManageBookBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			ManageBookBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			ManageBookBtn.DialogResult = DialogResult.None;
			ManageBookBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			ManageBookBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
			ManageBookBtn.ForeColor = Color.FromArgb(255, 255, 255);
			ManageBookBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			ManageBookBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			ManageBookBtn.HoverEffect = true;
			ManageBookBtn.Icon = (Image)resources.GetObject("ManageBookBtn.Icon");
			ManageBookBtn.IconPaddingX = 15;
			ManageBookBtn.IconPaddingY = 0;
			ManageBookBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			ManageBookBtn.IsBusy = false;
			ManageBookBtn.IsBusyText = "Busy, wait...";
			ManageBookBtn.Location = new Point(0, 282);
			ManageBookBtn.MinimumSize = new Size(100, 40);
			ManageBookBtn.Name = "ManageBookBtn";
			ManageBookBtn.RaiseError = false;
			ManageBookBtn.Size = new Size(226, 62);
			ManageBookBtn.TabIndex = 0;
			ManageBookBtn.Text = "          Kitap Yönetimi";
			ManageBookBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ManageBookBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ManageBookBtn.Click += ManageBookBtn_Click;
			// 
			// siticoneRadialPictureBox1
			// 
			siticoneRadialPictureBox1.BackColor = Color.White;
			siticoneRadialPictureBox1.Image = (Image)resources.GetObject("siticoneRadialPictureBox1.Image");
			siticoneRadialPictureBox1.Location = new Point(63, 15);
			siticoneRadialPictureBox1.Name = "siticoneRadialPictureBox1";
			siticoneRadialPictureBox1.Size = new Size(87, 87);
			siticoneRadialPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			siticoneRadialPictureBox1.TabIndex = 0;
			siticoneRadialPictureBox1.TabStop = false;
			// 
			// SettingBtn
			// 
			SettingBtn.BackColor = Color.Transparent;
			SettingBtn.BorderColor = Color.FromArgb(22, 32, 42);
			SettingBtn.BorderColorOnButtonPress = Color.FromArgb(22, 32, 42);
			SettingBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			SettingBtn.BorderRadiusAllRound = 1;
			SettingBtn.BorderRadiusLowerLeft = true;
			SettingBtn.BorderRadiusLowerRight = true;
			SettingBtn.BorderRadiusUpperLeft = true;
			SettingBtn.BorderRadiusUpperRight = true;
			SettingBtn.BorderThickness = 0;
			SettingBtn.ClickEffect = true;
			SettingBtn.ControlBackColor = Color.FromArgb(22, 32, 42);
			SettingBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			SettingBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			SettingBtn.DialogResult = DialogResult.None;
			SettingBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			SettingBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
			SettingBtn.ForeColor = Color.FromArgb(255, 255, 255);
			SettingBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			SettingBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			SettingBtn.HoverEffect = true;
			SettingBtn.Icon = (Image)resources.GetObject("SettingBtn.Icon");
			SettingBtn.IconPaddingX = 15;
			SettingBtn.IconPaddingY = 0;
			SettingBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			SettingBtn.IsBusy = false;
			SettingBtn.IsBusyText = "Busy, wait...";
			SettingBtn.Location = new Point(0, 487);
			SettingBtn.MinimumSize = new Size(100, 40);
			SettingBtn.Name = "SettingBtn";
			SettingBtn.RaiseError = false;
			SettingBtn.Size = new Size(226, 62);
			SettingBtn.TabIndex = 3;
			SettingBtn.Text = "Ayarlar";
			SettingBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			SettingBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			SettingBtn.Click += SettingBtn_Click;
			// 
			// ManageBorrowBtn
			// 
			ManageBorrowBtn.BackColor = Color.Transparent;
			ManageBorrowBtn.BorderColor = Color.FromArgb(22, 32, 42);
			ManageBorrowBtn.BorderColorOnButtonPress = Color.FromArgb(22, 32, 42);
			ManageBorrowBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			ManageBorrowBtn.BorderRadiusAllRound = 1;
			ManageBorrowBtn.BorderRadiusLowerLeft = true;
			ManageBorrowBtn.BorderRadiusLowerRight = true;
			ManageBorrowBtn.BorderRadiusUpperLeft = true;
			ManageBorrowBtn.BorderRadiusUpperRight = true;
			ManageBorrowBtn.BorderThickness = 0;
			ManageBorrowBtn.ClickEffect = true;
			ManageBorrowBtn.ControlBackColor = Color.FromArgb(22, 32, 42);
			ManageBorrowBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			ManageBorrowBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			ManageBorrowBtn.DialogResult = DialogResult.None;
			ManageBorrowBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			ManageBorrowBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
			ManageBorrowBtn.ForeColor = Color.FromArgb(255, 255, 255);
			ManageBorrowBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			ManageBorrowBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			ManageBorrowBtn.HoverEffect = true;
			ManageBorrowBtn.Icon = (Image)resources.GetObject("ManageBorrowBtn.Icon");
			ManageBorrowBtn.IconPaddingX = 15;
			ManageBorrowBtn.IconPaddingY = 0;
			ManageBorrowBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			ManageBorrowBtn.IsBusy = false;
			ManageBorrowBtn.IsBusyText = "Busy, wait...";
			ManageBorrowBtn.Location = new Point(0, 210);
			ManageBorrowBtn.MinimumSize = new Size(100, 40);
			ManageBorrowBtn.Name = "ManageBorrowBtn";
			ManageBorrowBtn.RaiseError = false;
			ManageBorrowBtn.Size = new Size(226, 62);
			ManageBorrowBtn.TabIndex = 2;
			ManageBorrowBtn.Text = "           Ödünç İşlemleri";
			ManageBorrowBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ManageBorrowBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ManageBorrowBtn.Click += ManageBorrowBtn_Click;
			// 
			// ManageUserBtn
			// 
			ManageUserBtn.BackColor = Color.Transparent;
			ManageUserBtn.BorderColor = Color.FromArgb(22, 32, 42);
			ManageUserBtn.BorderColorOnButtonPress = Color.FromArgb(22, 32, 42);
			ManageUserBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			ManageUserBtn.BorderRadiusAllRound = 1;
			ManageUserBtn.BorderRadiusLowerLeft = true;
			ManageUserBtn.BorderRadiusLowerRight = true;
			ManageUserBtn.BorderRadiusUpperLeft = true;
			ManageUserBtn.BorderRadiusUpperRight = true;
			ManageUserBtn.BorderThickness = 0;
			ManageUserBtn.ClickEffect = true;
			ManageUserBtn.ControlBackColor = Color.FromArgb(22, 32, 42);
			ManageUserBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			ManageUserBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			ManageUserBtn.DialogResult = DialogResult.None;
			ManageUserBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			ManageUserBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
			ManageUserBtn.ForeColor = Color.FromArgb(255, 255, 255);
			ManageUserBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			ManageUserBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			ManageUserBtn.HoverEffect = true;
			ManageUserBtn.Icon = (Image)resources.GetObject("ManageUserBtn.Icon");
			ManageUserBtn.IconPaddingX = 15;
			ManageUserBtn.IconPaddingY = 0;
			ManageUserBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			ManageUserBtn.IsBusy = false;
			ManageUserBtn.IsBusyText = "Busy, wait...";
			ManageUserBtn.Location = new Point(0, 358);
			ManageUserBtn.MinimumSize = new Size(100, 40);
			ManageUserBtn.Name = "ManageUserBtn";
			ManageUserBtn.RaiseError = false;
			ManageUserBtn.RightToLeft = RightToLeft.No;
			ManageUserBtn.Size = new Size(226, 62);
			ManageUserBtn.TabIndex = 1;
			ManageUserBtn.Text = "       Üye Yönetimi";
			ManageUserBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ManageUserBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ManageUserBtn.Click += ManageUserBtn_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(33, 57, 81);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1438, 55);
			panel1.TabIndex = 11;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.ForeColor = Color.White;
			label1.Location = new Point(3, 13);
			label1.Name = "label1";
			label1.Size = new Size(275, 28);
			label1.TabIndex = 11;
			label1.Text = "Kütüphane Yönetim Sistemi";
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button2.BackColor = Color.FromArgb(33, 57, 81);
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			button2.ForeColor = Color.White;
			button2.Location = new Point(1259, 0);
			button2.Name = "button2";
			button2.Size = new Size(63, 41);
			button2.TabIndex = 10;
			button2.Text = "―";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.BackColor = Color.FromArgb(33, 57, 81);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			button1.ForeColor = Color.White;
			button1.Location = new Point(1318, 0);
			button1.Name = "button1";
			button1.Size = new Size(63, 41);
			button1.TabIndex = 9;
			button1.Text = "▭";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// CenterPanel
			// 
			CenterPanel.Controls.Add(label2);
			CenterPanel.Controls.Add(MainPanel);
			CenterPanel.Controls.Add(siticoneFilledButton1);
			CenterPanel.Controls.Add(SearchTbx);
			CenterPanel.Dock = DockStyle.Fill;
			CenterPanel.Location = new Point(226, 55);
			CenterPanel.Name = "CenterPanel";
			CenterPanel.Size = new Size(1212, 747);
			CenterPanel.TabIndex = 12;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.FromArgb(27, 46, 61);
			label2.Location = new Point(37, 15);
			label2.Name = "label2";
			label2.Size = new Size(152, 41);
			label2.TabIndex = 3;
			label2.Text = "Kitaplar";
			// 
			// MainPanel
			// 
			MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			MainPanel.AutoScroll = true;
			MainPanel.BackColor = Color.Transparent;
			MainPanel.BorderColor = Color.Transparent;
			MainPanel.BorderRadiusLowerLeft = true;
			MainPanel.BorderRadiusLowerRight = true;
			MainPanel.BorderRadiusUpperLeft = true;
			MainPanel.BorderRadiusUpperRight = true;
			MainPanel.BorderThickness = 2;
			MainPanel.Location = new Point(37, 225);
			MainPanel.MinimumSize = new Size(20, 20);
			MainPanel.Name = "MainPanel";
			MainPanel.PanelBackColor = Color.Transparent;
			MainPanel.Radius = 10;
			MainPanel.Size = new Size(1163, 510);
			MainPanel.TabIndex = 2;
			MainPanel.VisualStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			// 
			// siticoneFilledButton1
			// 
			siticoneFilledButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			siticoneFilledButton1.BackColor = Color.Transparent;
			siticoneFilledButton1.BorderColor = Color.FromArgb(27, 46, 61);
			siticoneFilledButton1.BorderColorOnButtonPress = Color.FromArgb(97, 0, 255);
			siticoneFilledButton1.BorderColorOnHover = Color.FromArgb(97, 0, 255);
			siticoneFilledButton1.BorderRadiusAllRound = 28;
			siticoneFilledButton1.BorderRadiusLowerLeft = true;
			siticoneFilledButton1.BorderRadiusLowerRight = true;
			siticoneFilledButton1.BorderRadiusUpperLeft = true;
			siticoneFilledButton1.BorderRadiusUpperRight = true;
			siticoneFilledButton1.BorderThickness = 2;
			siticoneFilledButton1.ClickEffect = true;
			siticoneFilledButton1.ControlBackColor = Color.FromArgb(27, 46, 61);
			siticoneFilledButton1.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			siticoneFilledButton1.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			siticoneFilledButton1.DialogResult = DialogResult.None;
			siticoneFilledButton1.ErrorColor = Color.FromArgb(220, 53, 69);
			siticoneFilledButton1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			siticoneFilledButton1.ForeColor = Color.FromArgb(255, 255, 255);
			siticoneFilledButton1.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			siticoneFilledButton1.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			siticoneFilledButton1.HoverEffect = true;
			siticoneFilledButton1.Icon = null;
			siticoneFilledButton1.IconPaddingX = 0;
			siticoneFilledButton1.IconPaddingY = 0;
			siticoneFilledButton1.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			siticoneFilledButton1.IsBusy = false;
			siticoneFilledButton1.IsBusyText = "Busy, wait...";
			siticoneFilledButton1.Location = new Point(991, 143);
			siticoneFilledButton1.MinimumSize = new Size(100, 40);
			siticoneFilledButton1.Name = "siticoneFilledButton1";
			siticoneFilledButton1.RaiseError = false;
			siticoneFilledButton1.Size = new Size(209, 62);
			siticoneFilledButton1.TabIndex = 1;
			siticoneFilledButton1.Text = "Ara";
			siticoneFilledButton1.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			siticoneFilledButton1.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
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
			SearchTbx.Location = new Point(37, 143);
			SearchTbx.MakeLowercase = false;
			SearchTbx.MakeUppercase = false;
			SearchTbx.MinimumSize = new Size(150, 30);
			SearchTbx.Name = "SearchTbx";
			SearchTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			SearchTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			SearchTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			SearchTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			SearchTbx.PlaceholderText = "Kitap Aramak için İsim giriniz";
			SearchTbx.Radius = 31;
			SearchTbx.RightToLeft = RightToLeft.No;
			SearchTbx.ShowPasswordOnFocus = false;
			SearchTbx.Size = new Size(941, 62);
			SearchTbx.TabIndex = 0;
			SearchTbx.TextColor = Color.Black;
			SearchTbx.TrimStartEndSpaces = false;
			// 
			// OverdueCheckTimer
			// 
			OverdueCheckTimer.Tick += OverdueCheckTimer_Tick;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1438, 802);
			Controls.Add(CenterPanel);
			Controls.Add(siticoneRadialPanel1);
			Controls.Add(CloseBtn);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MainForm";
			TransparencyKey = Color.Red;
			Load += MainForm_Load;
			siticoneRadialPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)siticoneRadialPictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			CenterPanel.ResumeLayout(false);
			CenterPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Button CloseBtn;
		private SiticoneWinFormsUI.SiticoneRadialPanel siticoneRadialPanel1;
		private Panel panel1;
		private SiticoneWinFormsUI.SiticoneFilledButton ManageUserBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton ManageBookBtn;
		private Panel CenterPanel;
		private SiticoneWinFormsUI.SiticoneFilledButton ManageBorrowBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton SettingBtn;
		private Button button2;
		private Button button1;
		private Label label1;
		private SiticoneWinFormsUI.SiticoneRadialPictureBox siticoneRadialPictureBox1;
		private SiticoneWinFormsUI.SiticoneTextbox SearchTbx;
		private SiticoneWinFormsUI.SiticoneFilledButton siticoneFilledButton1;
		private SiticoneWinFormsUI.SiticoneRadialFlowLayoutPanel MainPanel;
		private Label label2;
		private SiticoneWinFormsUI.SiticoneFilledButton HomeFormBtn;
		public System.Windows.Forms.Timer OverdueCheckTimer;
	}
}