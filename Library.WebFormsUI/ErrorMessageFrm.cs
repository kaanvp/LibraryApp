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
	public partial class ErrorMessageFrm : Form
	{
		public string? MessageText
		{
			get { return Messagelbl.Text; }
			set { Messagelbl.Text = value; }
		}
		public ErrorMessageFrm(string message)
		{
			InitializeComponent();
			MessageText = message;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
