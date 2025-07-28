namespace Library.WebFormsUI
{
	partial class UpdateBookFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBookFrm));
			Locationcbx = new ComboBox();
			Categorycbx = new ComboBox();
			Authorscbx = new ComboBox();
			CloseBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			SaveBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			Pictxt = new PictureBox();
			ImageBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			ISBNTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			BookNameTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			SearchTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)Pictxt).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// Locationcbx
			// 
			Locationcbx.FlatStyle = FlatStyle.Flat;
			Locationcbx.FormattingEnabled = true;
			Locationcbx.Items.AddRange(new object[] { "admin\t", "kullanıcı" });
			Locationcbx.Location = new Point(44, 301);
			Locationcbx.Name = "Locationcbx";
			Locationcbx.Size = new Size(462, 28);
			Locationcbx.TabIndex = 23;
			Locationcbx.Text = "Kitap Konumu";
			// 
			// Categorycbx
			// 
			Categorycbx.FlatStyle = FlatStyle.Flat;
			Categorycbx.FormattingEnabled = true;
			Categorycbx.Items.AddRange(new object[] { "admin\t", "kullanıcı" });
			Categorycbx.Location = new Point(44, 252);
			Categorycbx.Name = "Categorycbx";
			Categorycbx.Size = new Size(462, 28);
			Categorycbx.TabIndex = 22;
			Categorycbx.Text = "Kategori";
			// 
			// Authorscbx
			// 
			Authorscbx.FlatStyle = FlatStyle.Flat;
			Authorscbx.FormattingEnabled = true;
			Authorscbx.Items.AddRange(new object[] { "admin\t", "kullanıcı" });
			Authorscbx.Location = new Point(44, 196);
			Authorscbx.Name = "Authorscbx";
			Authorscbx.Size = new Size(462, 28);
			Authorscbx.TabIndex = 21;
			Authorscbx.Text = "Kitap Yazarı";
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
			CloseBtn.Location = new Point(277, 682);
			CloseBtn.MinimumSize = new Size(100, 40);
			CloseBtn.Name = "CloseBtn";
			CloseBtn.RaiseError = false;
			CloseBtn.Size = new Size(209, 62);
			CloseBtn.TabIndex = 20;
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
			SaveBtn.Location = new Point(62, 682);
			SaveBtn.MinimumSize = new Size(100, 40);
			SaveBtn.Name = "SaveBtn";
			SaveBtn.RaiseError = false;
			SaveBtn.Size = new Size(209, 62);
			SaveBtn.TabIndex = 19;
			SaveBtn.Text = "Kaydet";
			SaveBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			SaveBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			SaveBtn.Click += SaveBtn_Click;
			// 
			// Pictxt
			// 
			Pictxt.BackColor = Color.Transparent;
			Pictxt.Image = (Image)resources.GetObject("Pictxt.Image");
			Pictxt.Location = new Point(44, 471);
			Pictxt.Name = "Pictxt";
			Pictxt.Size = new Size(209, 158);
			Pictxt.SizeMode = PictureBoxSizeMode.Zoom;
			Pictxt.TabIndex = 18;
			Pictxt.TabStop = false;
			// 
			// ImageBtn
			// 
			ImageBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ImageBtn.BackColor = Color.Transparent;
			ImageBtn.BorderColor = Color.FromArgb(27, 46, 61);
			ImageBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			ImageBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			ImageBtn.BorderRadiusAllRound = 28;
			ImageBtn.BorderRadiusLowerLeft = true;
			ImageBtn.BorderRadiusLowerRight = true;
			ImageBtn.BorderRadiusUpperLeft = true;
			ImageBtn.BorderRadiusUpperRight = true;
			ImageBtn.BorderThickness = 2;
			ImageBtn.ClickEffect = true;
			ImageBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			ImageBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			ImageBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			ImageBtn.DialogResult = DialogResult.None;
			ImageBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			ImageBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			ImageBtn.ForeColor = Color.FromArgb(255, 255, 255);
			ImageBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			ImageBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			ImageBtn.HoverEffect = true;
			ImageBtn.Icon = null;
			ImageBtn.IconPaddingX = 0;
			ImageBtn.IconPaddingY = 0;
			ImageBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			ImageBtn.IsBusy = false;
			ImageBtn.IsBusyText = "Busy, wait...";
			ImageBtn.Location = new Point(277, 530);
			ImageBtn.MinimumSize = new Size(100, 40);
			ImageBtn.Name = "ImageBtn";
			ImageBtn.RaiseError = false;
			ImageBtn.Size = new Size(209, 62);
			ImageBtn.TabIndex = 17;
			ImageBtn.Text = "Dosya Seç";
			ImageBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ImageBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ImageBtn.Click += ImageBtn_Click;
			// 
			// ISBNTbx
			// 
			ISBNTbx.AlwaysRadial = true;
			ISBNTbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ISBNTbx.AutoRadial = true;
			ISBNTbx.BorderColorOne = Color.FromArgb(170, 164, 213);
			ISBNTbx.BorderColorTwo = Color.FromArgb(170, 164, 213);
			ISBNTbx.BorderRadiusLowerLeft = true;
			ISBNTbx.BorderRadiusLowerRight = true;
			ISBNTbx.BorderRadiusUpperLeft = true;
			ISBNTbx.BorderRadiusUpperRight = true;
			ISBNTbx.BorderThickness = 1;
			ISBNTbx.ControlBackColor = Color.FromArgb(255, 255, 255);
			ISBNTbx.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ISBNTbx.EnableRightToLeft = false;
			ISBNTbx.ErrorColor = Color.Red;
			ISBNTbx.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
			ISBNTbx.IsPassword = false;
			ISBNTbx.IsReadonly = false;
			ISBNTbx.IsRequired = false;
			ISBNTbx.Location = new Point(44, 376);
			ISBNTbx.MakeLowercase = false;
			ISBNTbx.MakeUppercase = false;
			ISBNTbx.MinimumSize = new Size(150, 30);
			ISBNTbx.Name = "ISBNTbx";
			ISBNTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			ISBNTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			ISBNTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			ISBNTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			ISBNTbx.PlaceholderText = "ISBN";
			ISBNTbx.Radius = 25;
			ISBNTbx.RightToLeft = RightToLeft.No;
			ISBNTbx.ShowPasswordOnFocus = false;
			ISBNTbx.Size = new Size(462, 51);
			ISBNTbx.TabIndex = 16;
			ISBNTbx.TextColor = Color.Black;
			ISBNTbx.TrimStartEndSpaces = false;
			// 
			// BookNameTbx
			// 
			BookNameTbx.AlwaysRadial = true;
			BookNameTbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			BookNameTbx.AutoRadial = true;
			BookNameTbx.BorderColorOne = Color.FromArgb(170, 164, 213);
			BookNameTbx.BorderColorTwo = Color.FromArgb(170, 164, 213);
			BookNameTbx.BorderRadiusLowerLeft = true;
			BookNameTbx.BorderRadiusLowerRight = true;
			BookNameTbx.BorderRadiusUpperLeft = true;
			BookNameTbx.BorderRadiusUpperRight = true;
			BookNameTbx.BorderThickness = 1;
			BookNameTbx.ControlBackColor = Color.FromArgb(255, 255, 255);
			BookNameTbx.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			BookNameTbx.EnableRightToLeft = false;
			BookNameTbx.ErrorColor = Color.Red;
			BookNameTbx.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
			BookNameTbx.IsPassword = false;
			BookNameTbx.IsReadonly = false;
			BookNameTbx.IsRequired = false;
			BookNameTbx.Location = new Point(44, 117);
			BookNameTbx.MakeLowercase = false;
			BookNameTbx.MakeUppercase = false;
			BookNameTbx.MinimumSize = new Size(150, 30);
			BookNameTbx.Name = "BookNameTbx";
			BookNameTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			BookNameTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			BookNameTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			BookNameTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			BookNameTbx.PlaceholderText = "Kitap Adı";
			BookNameTbx.Radius = 25;
			BookNameTbx.RightToLeft = RightToLeft.No;
			BookNameTbx.ShowPasswordOnFocus = false;
			BookNameTbx.Size = new Size(462, 51);
			BookNameTbx.TabIndex = 15;
			BookNameTbx.TextColor = Color.Black;
			BookNameTbx.TrimStartEndSpaces = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(33, 57, 81);
			panel1.Controls.Add(label2);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1353, 82);
			panel1.TabIndex = 14;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.White;
			label2.Location = new Point(44, 19);
			label2.Name = "label2";
			label2.Size = new Size(316, 41);
			label2.TabIndex = 4;
			label2.Text = "Kitap Güncelleme";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.ForeColor = SystemColors.InactiveCaption;
			label1.Location = new Point(44, 332);
			label1.Name = "label1";
			label1.Size = new Size(285, 20);
			label1.TabIndex = 24;
			label1.Text = "(Kitap Konumu örneğin: \"A1 - 2 - Sol Alt)";
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
			SearchTbx.Location = new Point(590, 117);
			SearchTbx.MakeLowercase = false;
			SearchTbx.MakeUppercase = false;
			SearchTbx.MinimumSize = new Size(150, 30);
			SearchTbx.Name = "SearchTbx";
			SearchTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			SearchTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			SearchTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			SearchTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			SearchTbx.PlaceholderText = "Kitap Adı";
			SearchTbx.Radius = 25;
			SearchTbx.RightToLeft = RightToLeft.No;
			SearchTbx.ShowPasswordOnFocus = false;
			SearchTbx.Size = new Size(710, 51);
			SearchTbx.TabIndex = 28;
			SearchTbx.TextColor = Color.Black;
			SearchTbx.TrimStartEndSpaces = false;
			SearchTbx.TextChanged += SearchTbx_TextChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(590, 196);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(710, 559);
			dataGridView1.TabIndex = 27;
			dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
			// 
			// UpdateBookFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1353, 798);
			Controls.Add(SearchTbx);
			Controls.Add(dataGridView1);
			Controls.Add(Locationcbx);
			Controls.Add(Categorycbx);
			Controls.Add(Authorscbx);
			Controls.Add(CloseBtn);
			Controls.Add(SaveBtn);
			Controls.Add(Pictxt);
			Controls.Add(ImageBtn);
			Controls.Add(ISBNTbx);
			Controls.Add(BookNameTbx);
			Controls.Add(panel1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "UpdateBookFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "UpdateBookFrm";
			Load += UpdateBookFrm_Load;
			((System.ComponentModel.ISupportInitialize)Pictxt).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox Locationcbx;
		private ComboBox Categorycbx;
		private ComboBox Authorscbx;
		private SiticoneWinFormsUI.SiticoneFilledButton CloseBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton SaveBtn;
		private PictureBox Pictxt;
		private SiticoneWinFormsUI.SiticoneFilledButton ImageBtn;
		private SiticoneWinFormsUI.SiticoneTextbox ISBNTbx;
		private SiticoneWinFormsUI.SiticoneTextbox BookNameTbx;
		private Panel panel1;
		private Label label1;
		private Label label2;
		private SiticoneWinFormsUI.SiticoneTextbox SearchTbx;
		private DataGridView dataGridView1;
	}
}