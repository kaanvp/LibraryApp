namespace Library.WebFormsUI
{
	partial class ReturnFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnFrm));
			label6 = new Label();
			ReturnDaylbl = new Label();
			label4 = new Label();
			BorrowDatelbl = new Label();
			DueDatelbl = new Label();
			label2 = new Label();
			siticoneRadialPanel2 = new SiticoneWinFormsUI.SiticoneRadialPanel();
			label3 = new Label();
			ReturnBtn = new SiticoneWinFormsUI.SiticoneGradientButton();
			Column3 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			siticoneRadialPanel1 = new SiticoneWinFormsUI.SiticoneRadialPanel();
			RefreshBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			SearchTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			MainPanel = new SiticoneWinFormsUI.SiticoneRadialFlowLayoutPanel();
			siticoneRadialPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			siticoneRadialPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
			label6.ForeColor = Color.DarkGray;
			label6.Location = new Point(208, 123);
			label6.Name = "label6";
			label6.Size = new Size(72, 24);
			label6.TabIndex = 7;
			label6.Text = "gündür";
			// 
			// ReturnDaylbl
			// 
			ReturnDaylbl.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
			ReturnDaylbl.ForeColor = Color.DarkGray;
			ReturnDaylbl.Location = new Point(170, 123);
			ReturnDaylbl.Name = "ReturnDaylbl";
			ReturnDaylbl.Size = new Size(58, 24);
			ReturnDaylbl.TabIndex = 6;
			ReturnDaylbl.Text = "14";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
			label4.ForeColor = Color.DarkGray;
			label4.Location = new Point(16, 123);
			label4.Name = "label4";
			label4.Size = new Size(146, 24);
			label4.TabIndex = 5;
			label4.Text = "Gecikme Süresi";
			// 
			// BorrowDatelbl
			// 
			BorrowDatelbl.AutoSize = true;
			BorrowDatelbl.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			BorrowDatelbl.ForeColor = Color.DarkGray;
			BorrowDatelbl.Location = new Point(251, 42);
			BorrowDatelbl.Name = "BorrowDatelbl";
			BorrowDatelbl.Size = new Size(128, 26);
			BorrowDatelbl.TabIndex = 4;
			BorrowDatelbl.Text = "25.07.2025";
			// 
			// DueDatelbl
			// 
			DueDatelbl.AutoSize = true;
			DueDatelbl.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			DueDatelbl.ForeColor = Color.DarkGray;
			DueDatelbl.Location = new Point(164, 84);
			DueDatelbl.Name = "DueDatelbl";
			DueDatelbl.Size = new Size(128, 26);
			DueDatelbl.TabIndex = 3;
			DueDatelbl.Text = "25.07.2025";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.DimGray;
			label2.Location = new Point(11, 38);
			label2.Name = "label2";
			label2.Size = new Size(237, 35);
			label2.TabIndex = 1;
			label2.Text = "Ödünç Alma Tarihi:";
			// 
			// siticoneRadialPanel2
			// 
			siticoneRadialPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			siticoneRadialPanel2.BackColor = Color.Transparent;
			siticoneRadialPanel2.BorderColor = Color.Gainsboro;
			siticoneRadialPanel2.BorderRadiusLowerLeft = true;
			siticoneRadialPanel2.BorderRadiusLowerRight = true;
			siticoneRadialPanel2.BorderRadiusUpperLeft = true;
			siticoneRadialPanel2.BorderRadiusUpperRight = true;
			siticoneRadialPanel2.BorderThickness = 2;
			siticoneRadialPanel2.Controls.Add(label6);
			siticoneRadialPanel2.Controls.Add(ReturnDaylbl);
			siticoneRadialPanel2.Controls.Add(label4);
			siticoneRadialPanel2.Controls.Add(BorrowDatelbl);
			siticoneRadialPanel2.Controls.Add(DueDatelbl);
			siticoneRadialPanel2.Controls.Add(label3);
			siticoneRadialPanel2.Controls.Add(label2);
			siticoneRadialPanel2.Location = new Point(1077, 586);
			siticoneRadialPanel2.MinimumSize = new Size(20, 20);
			siticoneRadialPanel2.Name = "siticoneRadialPanel2";
			siticoneRadialPanel2.PanelBackColor = Color.Gainsboro;
			siticoneRadialPanel2.Radius = 10;
			siticoneRadialPanel2.Size = new Size(412, 156);
			siticoneRadialPanel2.TabIndex = 24;
			siticoneRadialPanel2.VisualStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.DottedContinuousDash;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.ForeColor = Color.DimGray;
			label3.Location = new Point(14, 80);
			label3.Name = "label3";
			label3.Size = new Size(144, 35);
			label3.TabIndex = 2;
			label3.Text = "İade Tarihi:";
			// 
			// ReturnBtn
			// 
			ReturnBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			ReturnBtn.BackColor = Color.Transparent;
			ReturnBtn.BorderThickness = 2;
			ReturnBtn.ClickDepth = SiticoneWinFormsUI.Helpers.ClickDepth.ClickDepth.Shallow;
			ReturnBtn.DialogResult = DialogResult.OK;
			ReturnBtn.DisabledFirstColor = Color.FromArgb(32, 0, 85);
			ReturnBtn.DisabledSecondColor = Color.FromArgb(32, 0, 85);
			ReturnBtn.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
			ReturnBtn.ForeColor = Color.White;
			ReturnBtn.GradientAngle = 0F;
			ReturnBtn.GradientAngleOnHover = 50F;
			ReturnBtn.GradientAngleOnPress = 65F;
			ReturnBtn.Icon = null;
			ReturnBtn.IconPaddingX = 0;
			ReturnBtn.IconPaddingY = 0;
			ReturnBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			ReturnBtn.IdleFirstColor = Color.FromArgb(33, 57, 81);
			ReturnBtn.IdleSecondColor = Color.FromArgb(33, 57, 81);
			ReturnBtn.IsBusy = false;
			ReturnBtn.IsBusyText = "Busy, wait...";
			ReturnBtn.Location = new Point(1077, 748);
			ReturnBtn.MinimumSize = new Size(100, 40);
			ReturnBtn.Name = "ReturnBtn";
			ReturnBtn.OnHoverFirstColor = Color.FromArgb(61, 177, 200);
			ReturnBtn.OnHoverSecondColor = Color.FromArgb(61, 177, 200);
			ReturnBtn.Opacity = true;
			ReturnBtn.Radius = 8;
			ReturnBtn.Size = new Size(412, 57);
			ReturnBtn.TabIndex = 23;
			ReturnBtn.Text = "İADE ET";
			ReturnBtn.Click += ReturnBtn_Click;
			// 
			// Column3
			// 
			Column3.HeaderText = "Yazar";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			Column3.Width = 125;
			// 
			// Column2
			// 
			Column2.HeaderText = "Kitap Adı";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			Column2.Width = 125;
			// 
			// Column1
			// 
			Column1.HeaderText = "Kitap ID";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.Width = 125;
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
			dataGridView1.Location = new Point(1077, 92);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(412, 486);
			dataGridView1.TabIndex = 22;
			dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.ForeColor = Color.White;
			label1.Location = new Point(97, 9);
			label1.Name = "label1";
			label1.Size = new Size(198, 41);
			label1.TabIndex = 0;
			label1.Text = "İade Kitaplar";
			// 
			// siticoneRadialPanel1
			// 
			siticoneRadialPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			siticoneRadialPanel1.BackColor = Color.Transparent;
			siticoneRadialPanel1.BorderColor = Color.FromArgb(33, 57, 81);
			siticoneRadialPanel1.BorderRadiusLowerLeft = true;
			siticoneRadialPanel1.BorderRadiusLowerRight = true;
			siticoneRadialPanel1.BorderRadiusUpperLeft = true;
			siticoneRadialPanel1.BorderRadiusUpperRight = true;
			siticoneRadialPanel1.BorderThickness = 1;
			siticoneRadialPanel1.Controls.Add(label1);
			siticoneRadialPanel1.Location = new Point(1077, 20);
			siticoneRadialPanel1.MinimumSize = new Size(20, 20);
			siticoneRadialPanel1.Name = "siticoneRadialPanel1";
			siticoneRadialPanel1.PanelBackColor = Color.FromArgb(33, 57, 81);
			siticoneRadialPanel1.Radius = 10;
			siticoneRadialPanel1.Size = new Size(412, 61);
			siticoneRadialPanel1.TabIndex = 21;
			siticoneRadialPanel1.VisualStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
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
			RefreshBtn.Location = new Point(886, 20);
			RefreshBtn.MinimumSize = new Size(100, 40);
			RefreshBtn.Name = "RefreshBtn";
			RefreshBtn.RaiseError = false;
			RefreshBtn.Size = new Size(173, 46);
			RefreshBtn.TabIndex = 20;
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
			SearchTbx.Location = new Point(19, 20);
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
			SearchTbx.Size = new Size(850, 46);
			SearchTbx.TabIndex = 19;
			SearchTbx.TextColor = Color.Black;
			SearchTbx.TrimStartEndSpaces = false;
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
			MainPanel.Location = new Point(19, 92);
			MainPanel.MinimumSize = new Size(20, 20);
			MainPanel.Name = "MainPanel";
			MainPanel.PanelBackColor = Color.Transparent;
			MainPanel.Radius = 10;
			MainPanel.Size = new Size(1040, 713);
			MainPanel.TabIndex = 18;
			MainPanel.VisualStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			// 
			// ReturnFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1494, 824);
			Controls.Add(siticoneRadialPanel2);
			Controls.Add(ReturnBtn);
			Controls.Add(dataGridView1);
			Controls.Add(siticoneRadialPanel1);
			Controls.Add(RefreshBtn);
			Controls.Add(SearchTbx);
			Controls.Add(MainPanel);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ReturnFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ReturnFrm";
			Load += ReturnFrm_Load;
			siticoneRadialPanel2.ResumeLayout(false);
			siticoneRadialPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			siticoneRadialPanel1.ResumeLayout(false);
			siticoneRadialPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label6;
		private Label ReturnDaylbl;
		private Label label4;
		private Label BorrowDatelbl;
		private Label DueDatelbl;
		private Label label2;
		private SiticoneWinFormsUI.SiticoneRadialPanel siticoneRadialPanel2;
		private Label label3;
		private SiticoneWinFormsUI.SiticoneGradientButton ReturnBtn;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column1;
		private DataGridView dataGridView1;
		private Label label1;
		private SiticoneWinFormsUI.SiticoneRadialPanel siticoneRadialPanel1;
		private SiticoneWinFormsUI.SiticoneFilledButton RefreshBtn;
		private SiticoneWinFormsUI.SiticoneTextbox SearchTbx;
		private SiticoneWinFormsUI.SiticoneRadialFlowLayoutPanel MainPanel;
	}
}