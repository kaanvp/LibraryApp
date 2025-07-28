namespace Library.WebFormsUI
{
	partial class ManageBorrowFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBorrowFrm));
			dataGridView1 = new DataGridView();
			materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			ReturnBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			BorrowBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			RefreshBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			SearchTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			AvailableBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			CheckedOutBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			OverdueBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			CenterPanel = new Panel();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			CenterPanel.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(30, 244);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1181, 406);
			dataGridView1.TabIndex = 15;
			dataGridView1.CellFormatting += dataGridView1_CellFormatting;
			// 
			// materialDivider1
			// 
			materialDivider1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
			materialDivider1.Depth = 0;
			materialDivider1.Location = new Point(30, 211);
			materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			materialDivider1.Name = "materialDivider1";
			materialDivider1.Size = new Size(1178, 10);
			materialDivider1.TabIndex = 14;
			materialDivider1.Text = "materialDivider1";
			// 
			// ReturnBtn
			// 
			ReturnBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ReturnBtn.BackColor = Color.Transparent;
			ReturnBtn.BorderColor = Color.FromArgb(27, 46, 61);
			ReturnBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			ReturnBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			ReturnBtn.BorderRadiusAllRound = 28;
			ReturnBtn.BorderRadiusLowerLeft = true;
			ReturnBtn.BorderRadiusLowerRight = true;
			ReturnBtn.BorderRadiusUpperLeft = true;
			ReturnBtn.BorderRadiusUpperRight = true;
			ReturnBtn.BorderThickness = 2;
			ReturnBtn.ClickEffect = true;
			ReturnBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			ReturnBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			ReturnBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			ReturnBtn.DialogResult = DialogResult.None;
			ReturnBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			ReturnBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			ReturnBtn.ForeColor = Color.FromArgb(255, 255, 255);
			ReturnBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			ReturnBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			ReturnBtn.HoverEffect = true;
			ReturnBtn.Icon = (Image)resources.GetObject("ReturnBtn.Icon");
			ReturnBtn.IconPaddingX = 10;
			ReturnBtn.IconPaddingY = 0;
			ReturnBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			ReturnBtn.IsBusy = false;
			ReturnBtn.IsBusyText = "Busy, wait...";
			ReturnBtn.Location = new Point(621, 12);
			ReturnBtn.MinimumSize = new Size(100, 40);
			ReturnBtn.Name = "ReturnBtn";
			ReturnBtn.RaiseError = false;
			ReturnBtn.Size = new Size(216, 62);
			ReturnBtn.TabIndex = 12;
			ReturnBtn.Text = "İade Et";
			ReturnBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ReturnBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			ReturnBtn.Click += ReturnBtn_Click;
			// 
			// BorrowBtn
			// 
			BorrowBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BorrowBtn.BackColor = Color.Transparent;
			BorrowBtn.BorderColor = Color.FromArgb(27, 46, 61);
			BorrowBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			BorrowBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			BorrowBtn.BorderRadiusAllRound = 28;
			BorrowBtn.BorderRadiusLowerLeft = true;
			BorrowBtn.BorderRadiusLowerRight = true;
			BorrowBtn.BorderRadiusUpperLeft = true;
			BorrowBtn.BorderRadiusUpperRight = true;
			BorrowBtn.BorderThickness = 2;
			BorrowBtn.ClickEffect = true;
			BorrowBtn.ControlBackColor = Color.FromArgb(27, 46, 61);
			BorrowBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			BorrowBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			BorrowBtn.DialogResult = DialogResult.None;
			BorrowBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			BorrowBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			BorrowBtn.ForeColor = Color.FromArgb(255, 255, 255);
			BorrowBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			BorrowBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			BorrowBtn.HoverEffect = true;
			BorrowBtn.Icon = (Image)resources.GetObject("BorrowBtn.Icon");
			BorrowBtn.IconPaddingX = 10;
			BorrowBtn.IconPaddingY = 0;
			BorrowBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			BorrowBtn.IsBusy = false;
			BorrowBtn.IsBusyText = "Busy, wait...";
			BorrowBtn.Location = new Point(334, 12);
			BorrowBtn.MinimumSize = new Size(100, 40);
			BorrowBtn.Name = "BorrowBtn";
			BorrowBtn.RaiseError = false;
			BorrowBtn.Size = new Size(222, 62);
			BorrowBtn.TabIndex = 11;
			BorrowBtn.Text = "Ödünç Al";
			BorrowBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			BorrowBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			BorrowBtn.Click += BorrowBtn_Click;
			// 
			// RefreshBtn
			// 
			RefreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			RefreshBtn.BackColor = Color.Transparent;
			RefreshBtn.BorderColor = Color.FromArgb(27, 46, 61);
			RefreshBtn.BorderColorOnButtonPress = Color.FromArgb(61, 177, 200);
			RefreshBtn.BorderColorOnHover = Color.FromArgb(61, 177, 200);
			RefreshBtn.BorderRadiusAllRound = 15;
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
			RefreshBtn.Location = new Point(960, 102);
			RefreshBtn.MinimumSize = new Size(100, 40);
			RefreshBtn.Name = "RefreshBtn";
			RefreshBtn.RaiseError = false;
			RefreshBtn.Size = new Size(251, 46);
			RefreshBtn.TabIndex = 10;
			RefreshBtn.Text = "Yenile";
			RefreshBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			RefreshBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
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
			SearchTbx.Location = new Point(27, 102);
			SearchTbx.MakeLowercase = false;
			SearchTbx.MakeUppercase = false;
			SearchTbx.MinimumSize = new Size(150, 30);
			SearchTbx.Name = "SearchTbx";
			SearchTbx.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
			SearchTbx.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
			SearchTbx.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
			SearchTbx.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
			SearchTbx.PlaceholderText = "Kitap Aramak için İsim,Kategori yada Konum giriniz";
			SearchTbx.Radius = 23;
			SearchTbx.RightToLeft = RightToLeft.No;
			SearchTbx.ShowPasswordOnFocus = false;
			SearchTbx.Size = new Size(927, 46);
			SearchTbx.TabIndex = 9;
			SearchTbx.TextColor = Color.Black;
			SearchTbx.TrimStartEndSpaces = false;
			SearchTbx.TextChanged += SearchTbx_TextChanged;
			// 
			// AvailableBtn
			// 
			AvailableBtn.BackColor = Color.Transparent;
			AvailableBtn.BorderColor = Color.MediumSeaGreen;
			AvailableBtn.BorderColorOnButtonPress = Color.MediumSeaGreen;
			AvailableBtn.BorderColorOnHover = Color.MediumSeaGreen;
			AvailableBtn.BorderRadiusAllRound = 1;
			AvailableBtn.BorderRadiusLowerLeft = false;
			AvailableBtn.BorderRadiusLowerRight = false;
			AvailableBtn.BorderRadiusUpperLeft = false;
			AvailableBtn.BorderRadiusUpperRight = false;
			AvailableBtn.BorderThickness = 2;
			AvailableBtn.ClickEffect = true;
			AvailableBtn.ControlBackColor = Color.MediumSeaGreen;
			AvailableBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			AvailableBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			AvailableBtn.DialogResult = DialogResult.None;
			AvailableBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			AvailableBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			AvailableBtn.ForeColor = Color.White;
			AvailableBtn.ForeColorOnHover = Color.White;
			AvailableBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			AvailableBtn.HoverEffect = true;
			AvailableBtn.Icon = null;
			AvailableBtn.IconPaddingX = 0;
			AvailableBtn.IconPaddingY = 0;
			AvailableBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			AvailableBtn.IsBusy = false;
			AvailableBtn.IsBusyText = "Busy, wait...";
			AvailableBtn.Location = new Point(30, 160);
			AvailableBtn.MinimumSize = new Size(100, 40);
			AvailableBtn.Name = "AvailableBtn";
			AvailableBtn.RaiseError = false;
			AvailableBtn.Size = new Size(222, 40);
			AvailableBtn.TabIndex = 16;
			AvailableBtn.Text = "Mevcut ";
			AvailableBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			AvailableBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			AvailableBtn.Click += AvailableBtn_Click;
			// 
			// CheckedOutBtn
			// 
			CheckedOutBtn.BackColor = Color.Transparent;
			CheckedOutBtn.BorderColor = Color.Crimson;
			CheckedOutBtn.BorderColorOnButtonPress = Color.Crimson;
			CheckedOutBtn.BorderColorOnHover = Color.Crimson;
			CheckedOutBtn.BorderRadiusAllRound = 1;
			CheckedOutBtn.BorderRadiusLowerLeft = false;
			CheckedOutBtn.BorderRadiusLowerRight = false;
			CheckedOutBtn.BorderRadiusUpperLeft = false;
			CheckedOutBtn.BorderRadiusUpperRight = false;
			CheckedOutBtn.BorderThickness = 2;
			CheckedOutBtn.ClickEffect = true;
			CheckedOutBtn.ControlBackColor = Color.Crimson;
			CheckedOutBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			CheckedOutBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			CheckedOutBtn.DialogResult = DialogResult.None;
			CheckedOutBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			CheckedOutBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			CheckedOutBtn.ForeColor = Color.FromArgb(255, 255, 255);
			CheckedOutBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			CheckedOutBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			CheckedOutBtn.HoverEffect = true;
			CheckedOutBtn.Icon = null;
			CheckedOutBtn.IconPaddingX = 0;
			CheckedOutBtn.IconPaddingY = 0;
			CheckedOutBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			CheckedOutBtn.IsBusy = false;
			CheckedOutBtn.IsBusyText = "Busy, wait...";
			CheckedOutBtn.Location = new Point(253, 160);
			CheckedOutBtn.MinimumSize = new Size(100, 40);
			CheckedOutBtn.Name = "CheckedOutBtn";
			CheckedOutBtn.RaiseError = false;
			CheckedOutBtn.Size = new Size(222, 40);
			CheckedOutBtn.TabIndex = 17;
			CheckedOutBtn.Text = "Ödüç verildi";
			CheckedOutBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CheckedOutBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			CheckedOutBtn.Click += CheckedOutBtn_Click;
			// 
			// OverdueBtn
			// 
			OverdueBtn.BackColor = Color.Transparent;
			OverdueBtn.BorderColor = Color.Orange;
			OverdueBtn.BorderColorOnButtonPress = Color.Orange;
			OverdueBtn.BorderColorOnHover = Color.Orange;
			OverdueBtn.BorderRadiusAllRound = 1;
			OverdueBtn.BorderRadiusLowerLeft = false;
			OverdueBtn.BorderRadiusLowerRight = false;
			OverdueBtn.BorderRadiusUpperLeft = false;
			OverdueBtn.BorderRadiusUpperRight = false;
			OverdueBtn.BorderThickness = 2;
			OverdueBtn.ClickEffect = true;
			OverdueBtn.ControlBackColor = Color.Orange;
			OverdueBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			OverdueBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			OverdueBtn.DialogResult = DialogResult.None;
			OverdueBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			OverdueBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			OverdueBtn.ForeColor = Color.FromArgb(255, 255, 255);
			OverdueBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			OverdueBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			OverdueBtn.HoverEffect = true;
			OverdueBtn.Icon = null;
			OverdueBtn.IconPaddingX = 0;
			OverdueBtn.IconPaddingY = 0;
			OverdueBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			OverdueBtn.IsBusy = false;
			OverdueBtn.IsBusyText = "Busy, wait...";
			OverdueBtn.Location = new Point(472, 160);
			OverdueBtn.MinimumSize = new Size(100, 40);
			OverdueBtn.Name = "OverdueBtn";
			OverdueBtn.RaiseError = false;
			OverdueBtn.Size = new Size(222, 40);
			OverdueBtn.TabIndex = 18;
			OverdueBtn.Text = "Gecikmiş İade";
			OverdueBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			OverdueBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			OverdueBtn.Click += OverdueBtn_Click;
			// 
			// CenterPanel
			// 
			CenterPanel.BackColor = Color.Transparent;
			CenterPanel.Controls.Add(OverdueBtn);
			CenterPanel.Controls.Add(CheckedOutBtn);
			CenterPanel.Controls.Add(ReturnBtn);
			CenterPanel.Controls.Add(AvailableBtn);
			CenterPanel.Controls.Add(BorrowBtn);
			CenterPanel.Dock = DockStyle.Fill;
			CenterPanel.Location = new Point(0, 0);
			CenterPanel.Name = "CenterPanel";
			CenterPanel.Size = new Size(1266, 676);
			CenterPanel.TabIndex = 19;
			// 
			// ManageBorrowFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1266, 676);
			Controls.Add(dataGridView1);
			Controls.Add(materialDivider1);
			Controls.Add(RefreshBtn);
			Controls.Add(SearchTbx);
			Controls.Add(CenterPanel);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageBorrowFrm";
			Text = "ManageBorrowFrm";
			Load += ManageBorrowFrm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			CenterPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private MaterialSkin.Controls.MaterialDivider materialDivider1;
		private SiticoneWinFormsUI.SiticoneFilledButton ReturnBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton BorrowBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton RefreshBtn;
		private SiticoneWinFormsUI.SiticoneTextbox SearchTbx;
		private SiticoneWinFormsUI.SiticoneFilledButton AvailableBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton CheckedOutBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton OverdueBtn;
		private Panel CenterPanel;
	}
}