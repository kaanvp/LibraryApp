namespace Library.WebFormsUI
{
	partial class ucBorrow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBorrow));
			AuthorNameuc = new Label();
			Imageuc = new PictureBox();
			BookNameuc = new Label();
			MainPanel = new SiticoneWinFormsUI.SiticoneFlatPanel();
			StatusBtn = new SiticoneWinFormsUI.SiticoneFilledButton();
			BorrowBtn = new SiticoneWinFormsUI.SiticoneGradientButton();
			((System.ComponentModel.ISupportInitialize)Imageuc).BeginInit();
			MainPanel.SuspendLayout();
			SuspendLayout();
			// 
			// AuthorNameuc
			// 
			AuthorNameuc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
			AuthorNameuc.ForeColor = Color.DarkGray;
			AuthorNameuc.Location = new Point(-1, 216);
			AuthorNameuc.Name = "AuthorNameuc";
			AuthorNameuc.Size = new Size(321, 34);
			AuthorNameuc.TabIndex = 7;
			AuthorNameuc.Text = "label2";
			AuthorNameuc.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Imageuc
			// 
			Imageuc.BackColor = Color.Transparent;
			Imageuc.Image = (Image)resources.GetObject("Imageuc.Image");
			Imageuc.Location = new Point(0, 0);
			Imageuc.Name = "Imageuc";
			Imageuc.Size = new Size(323, 179);
			Imageuc.SizeMode = PictureBoxSizeMode.Zoom;
			Imageuc.TabIndex = 5;
			Imageuc.TabStop = false;
			// 
			// BookNameuc
			// 
			BookNameuc.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			BookNameuc.ForeColor = Color.Black;
			BookNameuc.Location = new Point(2, 182);
			BookNameuc.Name = "BookNameuc";
			BookNameuc.Size = new Size(324, 34);
			BookNameuc.TabIndex = 6;
			BookNameuc.Text = "label1";
			BookNameuc.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// MainPanel
			// 
			MainPanel.BackColor = Color.Transparent;
			MainPanel.BorderColorBottom = Color.FromArgb(33, 57, 81);
			MainPanel.BorderColorLeft = Color.Transparent;
			MainPanel.BorderColorRight = Color.Transparent;
			MainPanel.BorderColorTop = Color.Transparent;
			MainPanel.BorderStyleBottom = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			MainPanel.BorderStyleLeft = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			MainPanel.BorderStyleRight = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			MainPanel.BorderStyleTop = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			MainPanel.BorderThicknessBottom = 30;
			MainPanel.BorderThicknessLeft = 1;
			MainPanel.BorderThicknessRight = 1;
			MainPanel.BorderThicknessTop = 1;
			MainPanel.Controls.Add(StatusBtn);
			MainPanel.Controls.Add(BorrowBtn);
			MainPanel.Controls.Add(AuthorNameuc);
			MainPanel.Controls.Add(Imageuc);
			MainPanel.Controls.Add(BookNameuc);
			MainPanel.Cursor = Cursors.Hand;
			MainPanel.Location = new Point(1, 0);
			MainPanel.MinimumSize = new Size(20, 20);
			MainPanel.Name = "MainPanel";
			MainPanel.Size = new Size(323, 370);
			MainPanel.TabIndex = 6;
			// 
			// StatusBtn
			// 
			StatusBtn.BackColor = Color.Transparent;
			StatusBtn.BorderColor = Color.MediumSeaGreen;
			StatusBtn.BorderColorOnButtonPress = Color.FromArgb(97, 0, 255);
			StatusBtn.BorderColorOnHover = Color.FromArgb(97, 0, 255);
			StatusBtn.BorderRadiusAllRound = 16;
			StatusBtn.BorderRadiusLowerLeft = true;
			StatusBtn.BorderRadiusLowerRight = true;
			StatusBtn.BorderRadiusUpperLeft = true;
			StatusBtn.BorderRadiusUpperRight = true;
			StatusBtn.BorderThickness = 2;
			StatusBtn.ClickEffect = true;
			StatusBtn.ControlBackColor = Color.MediumSeaGreen;
			StatusBtn.ControlBackColorOnDisabled = Color.FromArgb(21, 0, 56);
			StatusBtn.ControlBorderColorOnDisabled = Color.FromArgb(21, 0, 56);
			StatusBtn.DialogResult = DialogResult.None;
			StatusBtn.Enabled = false;
			StatusBtn.ErrorColor = Color.FromArgb(220, 53, 69);
			StatusBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
			StatusBtn.ForeColor = Color.White;
			StatusBtn.ForeColorOnHover = Color.FromArgb(255, 255, 255);
			StatusBtn.ForeColorOnPress = Color.FromArgb(255, 255, 255);
			StatusBtn.HoverEffect = true;
			StatusBtn.Icon = null;
			StatusBtn.IconPaddingX = 0;
			StatusBtn.IconPaddingY = 0;
			StatusBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			StatusBtn.IsBusy = false;
			StatusBtn.IsBusyText = "Busy, wait...";
			StatusBtn.Location = new Point(95, 253);
			StatusBtn.MinimumSize = new Size(100, 40);
			StatusBtn.Name = "StatusBtn";
			StatusBtn.RaiseError = false;
			StatusBtn.Size = new Size(121, 40);
			StatusBtn.TabIndex = 9;
			StatusBtn.Text = "MEVCUT";
			StatusBtn.VisualStyleOnIdle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			StatusBtn.VisualStyleOnInteractive = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
			// 
			// BorrowBtn
			// 
			BorrowBtn.BackColor = Color.Transparent;
			BorrowBtn.BorderThickness = 2;
			BorrowBtn.ClickDepth = SiticoneWinFormsUI.Helpers.ClickDepth.ClickDepth.Shallow;
			BorrowBtn.DialogResult = DialogResult.OK;
			BorrowBtn.DisabledFirstColor = Color.FromArgb(32, 0, 85);
			BorrowBtn.DisabledSecondColor = Color.FromArgb(32, 0, 85);
			BorrowBtn.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			BorrowBtn.ForeColor = Color.White;
			BorrowBtn.GradientAngle = 0F;
			BorrowBtn.GradientAngleOnHover = 50F;
			BorrowBtn.GradientAngleOnPress = 65F;
			BorrowBtn.Icon = null;
			BorrowBtn.IconPaddingX = 0;
			BorrowBtn.IconPaddingY = 0;
			BorrowBtn.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
			BorrowBtn.IdleFirstColor = Color.FromArgb(51, 145, 209);
			BorrowBtn.IdleSecondColor = Color.FromArgb(44, 70, 93);
			BorrowBtn.IsBusy = false;
			BorrowBtn.IsBusyText = "Busy, wait...";
			BorrowBtn.Location = new Point(39, 306);
			BorrowBtn.MinimumSize = new Size(100, 40);
			BorrowBtn.Name = "BorrowBtn";
			BorrowBtn.OnHoverFirstColor = Color.FromArgb(61, 177, 200);
			BorrowBtn.OnHoverSecondColor = Color.FromArgb(61, 177, 200);
			BorrowBtn.Opacity = true;
			BorrowBtn.Radius = 8;
			BorrowBtn.Size = new Size(237, 41);
			BorrowBtn.TabIndex = 8;
			BorrowBtn.Text = "ÖDÜNÇ AL";
			BorrowBtn.Click += BorrowBtn_Click;
			// 
			// ucBorrow
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(MainPanel);
			Name = "ucBorrow";
			Size = new Size(324, 370);
			((System.ComponentModel.ISupportInitialize)Imageuc).EndInit();
			MainPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label AuthorNameuc;
		private PictureBox Imageuc;
		private Label BookNameuc;
		private SiticoneWinFormsUI.SiticoneFlatPanel MainPanel;
		private SiticoneWinFormsUI.SiticoneGradientButton BorrowBtn;
		private SiticoneWinFormsUI.SiticoneFilledButton StatusBtn;
	}
}
