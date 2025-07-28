using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUI
{
	public partial class ucBook : UserControl
	{
		public ucBook()
		{
			InitializeComponent();
		}
		public string? Bookname
		{
			get { return BookNameuc.Text; }
			set { BookNameuc.Text = value; }
		}
		public string? Authorname
		{
			get { return AuthorNameuc.Text; }
			set { AuthorNameuc.Text = value; }
		}
		public Image? PImage
		{
			get { return Imageuc.Image; }
			set { Imageuc.Image = value; }
		}
		private zoomForm zoomForm;
		private void Imageuc_MouseEnter(object sender, EventArgs e)
		{
			if (zoomForm == null || zoomForm.IsDisposed)
			{
				// Yeni formu oluştur
				zoomForm = new zoomForm(Imageuc.Image);

				// Mouse ekran konumunu al
				Point mousePosition = Cursor.Position;

				// Ekrandan taşmaması için ekran boyutunu al
				Rectangle screenBounds = Screen.FromPoint(mousePosition).WorkingArea;

				int formWidth = 250;
				int formHeight = 350;

				int x = mousePosition.X + 20;
				int y = mousePosition.Y + 20;

				// Eğer ekran dışına çıkıyorsa, pozisyonu ayarla
				if (x + formWidth > screenBounds.Right)
					x = mousePosition.X - formWidth - 20;

				if (y + formHeight > screenBounds.Bottom)
					y = mousePosition.Y - formHeight - 20;

				// Form boyutunu ayarla
				zoomForm.Size = new Size(formWidth, formHeight);
				zoomForm.Location = new Point(x, y);

				zoomForm.Show();
			}
		}

		private void Imageuc_MouseLeave(object sender, EventArgs e)
		{
			if (zoomForm != null && !zoomForm.IsDisposed)
			{
				zoomForm.Close();
				zoomForm = null;
			}
		}
	}

}
