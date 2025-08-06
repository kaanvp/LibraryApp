using Library.Bussines.Managers;
using Library.DataAccess.Context;
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
	public partial class MainForm : Form
	{
		public static Panel CenterPanelReference;
		
		private readonly BorrowManager _borrowManager;
		private System.Windows.Forms.Timer _overdueCheckTimer;
		private string _role;
		public MainForm(string role)
		{
			InitializeComponent();
			_role = role; // Kullanıcı rolünü al 
			CenterPanelReference = this.CenterPanel;
			_borrowManager = new BorrowManager();
			SetupOverdueCheck(); // Gecikme kontrolü için zamanlayıcıyı ayarla

		}
		private void SetupOverdueCheck()
		{
			_overdueCheckTimer = new System.Windows.Forms.Timer();
			_overdueCheckTimer.Interval = 3600000; // Her saat kontrol
			_overdueCheckTimer.Tick += OverdueCheckTimer_Tick;
			_overdueCheckTimer.Start();

			// İlk kontrolü hemen yap
			_borrowManager.CheckOverdueBooks();
		}
		private void OverdueCheckTimer_Tick(object sender, EventArgs e)
		{
			_borrowManager.CheckOverdueBooks();
		}
		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (_role == "admin")
			{


			}
			else if (_role == "kullanıcı")
			{
				// Kullanıcı rolü için butonları gizle
				ManageBookBtn.Visible = false;
				ManageUserBtn.Visible = false;
			}
			AddControls(new HomeFrm());
		}
		public static void AddControls(Form F)
		{
			CenterPanelReference.Controls.Clear();
			F.Dock = DockStyle.Fill;
			F.TopLevel = false;
			CenterPanelReference.Controls.Add(F);
			F.Show();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				this.WindowState = FormWindowState.Maximized;
			}
			else
			{
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void ManageBookBtn_Click(object sender, EventArgs e)
		{
			AddControls(new ManageBookFrm());
		}
		private void ManageUserBtn_Click(object sender, EventArgs e)
		{
			AddControls(new ManageUserFrm());
		}

		private void ManageBorrowBtn_Click(object sender, EventArgs e)
		{
			AddControls(new ManageBorrowFrm());
		}
		private void MainFormBtn_Click(object sender, EventArgs e)
		{
			AddControls(new HomeFrm());
		}

		private void SettingBtn_Click(object sender, EventArgs e)
		{
			AddControls(new SettingsFrm());
		}
	}
}
