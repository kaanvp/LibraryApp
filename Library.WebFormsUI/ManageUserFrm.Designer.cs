namespace Library.WebFormsUI
{
	partial class ManageUserFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserFrm));
			materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			DeleteBookBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			UpdateBookBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			AddBookBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			RefreshBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			SearchTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// materialDivider1
			// 
			materialDivider1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
			materialDivider1.Depth = 0;
			materialDivider1.Location = new Point(38, 222);
			materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			materialDivider1.Name = "materialDivider1";
			materialDivider1.Size = new Size(1101, 10);
			materialDivider1.TabIndex = 13;
			materialDivider1.Text = "materialDivider1";
			// 
			// DeleteBookBtn
			// 
			DeleteBookBtn.BackColor = Color.Transparent;
			DeleteBookBtn.BorderColor = Color.FromArgb(27, 46, 61);
			DeleteBookBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			DeleteBookBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			DeleteBookBtn.BorderRadiusAllRound = 28;
			DeleteBookBtn.BorderRadiusLowerLeft = true;
			DeleteBookBtn.BorderRadiusLowerRight = true;
			DeleteBookBtn.BorderRadiusUpperLeft = true;
			DeleteBookBtn.BorderRadiusUpperRight = true;
			DeleteBookBtn.BorderThickness = 2;
			DeleteBookBtn.ClickEffect = true;
			DeleteBookBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			DeleteBookBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			DeleteBookBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			DeleteBookBtn.DialogResult = DialogResult.None;
			DeleteBookBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			DeleteBookBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			DeleteBookBtn.ForeColor = Color.FromArgb(255, 255, 255);
			DeleteBookBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			DeleteBookBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			DeleteBookBtn.HoverEffect = true;
			DeleteBookBtn.Icon = (Image)resources.GetObject("DeleteBookBtn.Icon");
			DeleteBookBtn.IconPaddingX = 10;
			DeleteBookBtn.IconPaddingY = 0;
			DeleteBookBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			DeleteBookBtn.IsBusy = false;
			DeleteBookBtn.IsBusyText = "Busy, wait...";
			DeleteBookBtn.Location = new Point(592, 53);
			DeleteBookBtn.MinimumSize = new Size(100, 40);
			DeleteBookBtn.Name = "DeleteBookBtn";
			DeleteBookBtn.RaiseError = false;
			DeleteBookBtn.Size = new Size(244, 62);
			DeleteBookBtn.TabIndex = 12;
			DeleteBookBtn.Text = "Sil";
			DeleteBookBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			DeleteBookBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			DeleteBookBtn.Click += DeleteBookBtn_Click;
			// 
			// UpdateBookBtn
			// 
			UpdateBookBtn.BackColor = Color.Transparent;
			UpdateBookBtn.BorderColor = Color.FromArgb(27, 46, 61);
			UpdateBookBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			UpdateBookBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			UpdateBookBtn.BorderRadiusAllRound = 28;
			UpdateBookBtn.BorderRadiusLowerLeft = true;
			UpdateBookBtn.BorderRadiusLowerRight = true;
			UpdateBookBtn.BorderRadiusUpperLeft = true;
			UpdateBookBtn.BorderRadiusUpperRight = true;
			UpdateBookBtn.BorderThickness = 2;
			UpdateBookBtn.ClickEffect = true;
			UpdateBookBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			UpdateBookBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			UpdateBookBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			UpdateBookBtn.DialogResult = DialogResult.None;
			UpdateBookBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			UpdateBookBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			UpdateBookBtn.ForeColor = Color.FromArgb(255, 255, 255);
			UpdateBookBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			UpdateBookBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			UpdateBookBtn.HoverEffect = true;
			UpdateBookBtn.Icon = (Image)resources.GetObject("UpdateBookBtn.Icon");
			UpdateBookBtn.IconPaddingX = 10;
			UpdateBookBtn.IconPaddingY = 0;
			UpdateBookBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			UpdateBookBtn.IsBusy = false;
			UpdateBookBtn.IsBusyText = "Busy, wait...";
			UpdateBookBtn.Location = new Point(310, 53);
			UpdateBookBtn.MinimumSize = new Size(100, 40);
			UpdateBookBtn.Name = "UpdateBookBtn";
			UpdateBookBtn.RaiseError = false;
			UpdateBookBtn.Size = new Size(244, 62);
			UpdateBookBtn.TabIndex = 11;
			UpdateBookBtn.Text = "Güncelle";
			UpdateBookBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			UpdateBookBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			UpdateBookBtn.Click += UpdateBookBtn_Click;
			// 
			// AddBookBtn
			// 
			AddBookBtn.BackColor = Color.Transparent;
			AddBookBtn.BorderColor = Color.FromArgb(27, 46, 61);
			AddBookBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			AddBookBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			AddBookBtn.BorderRadiusAllRound = 28;
			AddBookBtn.BorderRadiusLowerLeft = true;
			AddBookBtn.BorderRadiusLowerRight = true;
			AddBookBtn.BorderRadiusUpperLeft = true;
			AddBookBtn.BorderRadiusUpperRight = true;
			AddBookBtn.BorderThickness = 2;
			AddBookBtn.ClickEffect = true;
			AddBookBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			AddBookBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			AddBookBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			AddBookBtn.DialogResult = DialogResult.None;
			AddBookBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			AddBookBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			AddBookBtn.ForeColor = Color.FromArgb(255, 255, 255);
			AddBookBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			AddBookBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			AddBookBtn.HoverEffect = true;
			AddBookBtn.Icon = (Image)resources.GetObject("AddBookBtn.Icon");
			AddBookBtn.IconPaddingX = 10;
			AddBookBtn.IconPaddingY = 0;
			AddBookBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			AddBookBtn.IsBusy = false;
			AddBookBtn.IsBusyText = "Busy, wait...";
			AddBookBtn.Location = new Point(38, 53);
			AddBookBtn.MinimumSize = new Size(100, 40);
			AddBookBtn.Name = "AddBookBtn";
			AddBookBtn.RaiseError = false;
			AddBookBtn.Size = new Size(244, 62);
			AddBookBtn.TabIndex = 10;
			AddBookBtn.Text = "Yeni Kullanıcı Ekle";
			AddBookBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			AddBookBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			AddBookBtn.Click += AddBookBtn_Click;
			// 
			// RefreshBtn
			// 
			RefreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			RefreshBtn.BackColor = Color.Transparent;
			RefreshBtn.BorderColor = Color.FromArgb(27, 46, 61);
			RefreshBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			RefreshBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			RefreshBtn.BorderRadiusAllRound = 28;
			RefreshBtn.BorderRadiusLowerLeft = true;
			RefreshBtn.BorderRadiusLowerRight = true;
			RefreshBtn.BorderRadiusUpperLeft = true;
			RefreshBtn.BorderRadiusUpperRight = true;
			RefreshBtn.BorderThickness = 2;
			RefreshBtn.ClickEffect = true;
			RefreshBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			RefreshBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			RefreshBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			RefreshBtn.DialogResult = DialogResult.None;
			RefreshBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			RefreshBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			RefreshBtn.ForeColor = Color.FromArgb(255, 255, 255);
			RefreshBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			RefreshBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			RefreshBtn.HoverEffect = true;
			RefreshBtn.Icon = (Image)resources.GetObject("RefreshBtn.Icon");
			RefreshBtn.IconPaddingX = 10;
			RefreshBtn.IconPaddingY = 0;
			RefreshBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			RefreshBtn.IsBusy = false;
			RefreshBtn.IsBusyText = "Busy, wait...";
			RefreshBtn.Location = new Point(930, 144);
			RefreshBtn.MinimumSize = new Size(100, 40);
			RefreshBtn.Name = "RefreshBtn";
			RefreshBtn.RaiseError = false;
			RefreshBtn.Size = new Size(209, 62);
			RefreshBtn.TabIndex = 9;
			RefreshBtn.Text = "Yenile";
			RefreshBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			RefreshBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			RefreshBtn.Click += RefreshBtn_Click;
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
			SearchTbx.Location = new Point(38, 144);
			SearchTbx.MakeLowercase = false;
			SearchTbx.MakeUppercase = false;
			SearchTbx.MinimumSize = new Size(150, 30);
			SearchTbx.Name = "SearchTbx";
			SearchTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			SearchTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			SearchTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			SearchTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			SearchTbx.PlaceholderText = "Aramak için Kullanıcı Adı giriniz";
			SearchTbx.Radius = 31;
			SearchTbx.RightToLeft = RightToLeft.No;
			SearchTbx.ShowPasswordOnFocus = false;
			SearchTbx.Size = new Size(886, 62);
			SearchTbx.TabIndex = 8;
			SearchTbx.TextColor = Color.Black;
			SearchTbx.TrimStartEndSpaces = false;
			SearchTbx.TextChanged += SearchTbx_TextChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(38, 268);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1101, 387);
			dataGridView1.TabIndex = 14;
			// 
			// ManageUserFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1150, 691);
			Controls.Add(dataGridView1);
			Controls.Add(materialDivider1);
			Controls.Add(DeleteBookBtn);
			Controls.Add(UpdateBookBtn);
			Controls.Add(AddBookBtn);
			Controls.Add(RefreshBtn);
			Controls.Add(SearchTbx);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageUserFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "UserManageFrm";
			Load += UserManageFrm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private MaterialSkin.Controls.MaterialDivider materialDivider1;
		private SiticoneWinFormsUI.SiticoneFilledButton DeleteBookBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton UpdateBookBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton AddBookBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton RefreshBtn;
		private SiticoneWinFormsUI.SiticoneTextbox SearchTbx;
		private DataGridView dataGridView1;
	}
}