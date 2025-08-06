namespace Library.WebFormsUI
{
	partial class HomeFrm
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
			label2 = new Label();
			MainPanel = new SiticoneWinFormsUI.SiticoneRadialFlowLayoutPanel();
			siticoneFilledButton1 = new SiticoneWinFormsUI.SiticoneFilledButton();
			SearchTbx = new SiticoneWinFormsUI.SiticoneTextbox();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.FromArgb(27, 46, 61);
			label2.Location = new Point(25, 13);
			label2.Name = "label2";
			label2.Size = new Size(152, 41);
			label2.TabIndex = 7;
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
			MainPanel.Location = new Point(25, 223);
			MainPanel.MinimumSize = new Size(20, 20);
			MainPanel.Name = "MainPanel";
			MainPanel.PanelBackColor = Color.Transparent;
			MainPanel.Radius = 10;
			MainPanel.Size = new Size(1163, 510);
			MainPanel.TabIndex = 6;
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
			siticoneFilledButton1.Location = new Point(979, 141);
			siticoneFilledButton1.MinimumSize = new Size(100, 40);
			siticoneFilledButton1.Name = "siticoneFilledButton1";
			siticoneFilledButton1.RaiseError = false;
			siticoneFilledButton1.Size = new Size(209, 62);
			siticoneFilledButton1.TabIndex = 5;
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
			SearchTbx.Location = new Point(25, 141);
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
			SearchTbx.TabIndex = 4;
			SearchTbx.TextColor = Color.Black;
			SearchTbx.TrimStartEndSpaces = false;
			SearchTbx.TextChanged += SearchTbx_TextChanged;
			// 
			// HomeFrm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1212, 747);
			Controls.Add(label2);
			Controls.Add(MainPanel);
			Controls.Add(siticoneFilledButton1);
			Controls.Add(SearchTbx);
			FormBorderStyle = FormBorderStyle.None;
			Name = "HomeFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "HomeFrm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private SiticoneWinFormsUI.SiticoneRadialFlowLayoutPanel MainPanel;
		private SiticoneWinFormsUI.SiticoneFilledButton siticoneFilledButton1;
		private SiticoneWinFormsUI.SiticoneTextbox SearchTbx;
	}
}