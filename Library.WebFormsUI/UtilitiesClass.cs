using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUI
{
	public static class UtilitiesClass
	{
		public static void BlurBackground(Form modalForm, Form parentForm)
		{
			using Form background = new()
			{

				StartPosition = FormStartPosition.Manual,
				FormBorderStyle = FormBorderStyle.None,
				Opacity = 0.5,
				BackColor = Color.Black,
				ShowInTaskbar = false,
				TopMost = false,
				Location = new Point(0, 0),
				Size = new Size(1920, 1080) // Manuel boyut

			}; 

			background.Show();
			modalForm.Owner = background;
			modalForm.ShowDialog();
		}
		public static void DatagridviewStyle(DataGridView dataGridView)
		{
			// Kenarlıklar ve arka plan
			dataGridView.BorderStyle = BorderStyle.None;
			dataGridView.BackgroundColor = Color.White;
			dataGridView.GridColor = Color.WhiteSmoke;
			dataGridView.EnableHeadersVisualStyles = false;

			// Satır stili
			dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
			dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // çok hafif gri
			dataGridView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
			dataGridView.RowsDefaultCellStyle.ForeColor = Color.Black;
			dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 210, 250); // seçili arka plan
			dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

			// Hücre kenarlıkları
			dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

			// Kolon başlıkları
			dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 46, 61); // koyu mavi
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView.ColumnHeadersHeight = 40;

			// Otomatik sütun genişliği
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Satır yüksekliği
			dataGridView.RowTemplate.Height = 35;

			// Satır başlıklarını gizle
			dataGridView.RowHeadersVisible = false;
		}
		public static bool Validation(Form F)
		{
			bool isValid = false;
			int count = 0;

			foreach (Control c in F.Controls)
			{
				// using tag of the control to check if we want to validate it or  not
				if (Convert.ToString(c.Tag) != "" && Convert.ToString(c.Tag) != null)
				{
					// for textbox
					if (c is SiticoneWinFormsUI.SiticoneTextbox)
					{
						SiticoneWinFormsUI.SiticoneTextbox t = (SiticoneWinFormsUI.SiticoneTextbox)c;
						if (t.Text.Trim() == "")
						{
							t.BorderColorOne = Color.Red;
							t.BorderColorTwo = Color.Red;
							t.OnFocusBorderColorOne = Color.Red;
							t.OnFocusBorderColorTwo = Color.Red;
							t.OnHoverBorderColorOne = Color.Red;
							t.OnHoverBorderColorTwo = Color.Red;
							
							count++;
						}
						else
						{
							t.BorderColorOne = Color.FromArgb(213, 218, 223);
							t.BorderColorTwo = Color.FromArgb(213, 218, 223);
							t.OnFocusBorderColorOne = Color.FromArgb(21, 76, 121);
							t.OnFocusBorderColorTwo = Color.FromArgb(21, 76, 121);
							t.OnHoverBorderColorOne = Color.FromArgb(21, 76, 121);
							t.OnHoverBorderColorTwo = Color.FromArgb(21, 76, 121);
						}
					}
					// for combobox
					if (c is System.Windows.Forms.ComboBox)
					{
						System.Windows.Forms.ComboBox t = (System.Windows.Forms.ComboBox)c;
						if (t.SelectedIndex == -1)
						{
							count++;
						}
						else
						{
						}
					}
				}
				if (count == 0)
				{
					isValid = true;
				}
				else
				{
					isValid = false;
				}
			}
			return isValid;
		}



	}

}
