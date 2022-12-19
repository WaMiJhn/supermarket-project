using RhClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobertHeijnDesktopApp
{
	public partial class LoginForm : Form
	{
		private readonly IAccountManager accountManager;
		public LoginForm(IAccountManager accountManager)
		{
			InitializeComponent();
			this.accountManager = accountManager;
		}
		private void btnClose_MouseEnter(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.Red;
			btnClose.ForeColor = Color.White;
		}

		private void btnClose_MouseLeave(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.White;
			btnClose.ForeColor = Color.FromArgb(0, 160, 226);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			try
			{
				//DialogResult result = MessageBox.Show("Are you sure you would like to exit the program?", "", MessageBoxButtons.YesNo);
				//if (result == DialogResult.Yes) { Application.Exit(); }
				Application.Exit();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
				{
					throw new Exception("Please fill in a username and a password.");
				}
				if (accountManager.LoginValidationEmployee(tbUsername.Text, tbPassword.Text))
				{
					this.Hide(); new DashboardForm().Show();
				}
				else
				{
					throw new Exception("The password you entered is incorrect, please try again.");
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
	}
}
