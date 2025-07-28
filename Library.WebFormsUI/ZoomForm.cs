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
	public partial class zoomForm : Form
	{
		public zoomForm(Image imageToShow)
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			this.StartPosition = FormStartPosition.Manual;
			this.TopMost = true;
			this.ShowInTaskbar = false;
			this.BackColor = Color.Black;
			this.Opacity = 0.95;
			this.Size = new Size(300, 500); // büyüklük ihtiyaca göre

			PictureBox pictureBox = new PictureBox();
			pictureBox.Dock = DockStyle.Fill;
			pictureBox.Image = imageToShow;
			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

			this.Controls.Add(pictureBox);
		}
	}
}
