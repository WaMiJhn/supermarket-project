using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobertHeijnDesktopApp
{
	public partial class EmployeeContentForm : Form
	{
		private bool drag = false;
		private Point start = new Point(0, 0);
		public EmployeeContentForm()
		{
			InitializeComponent();
		}
		private void tbPassword_TextChanged(object sender, EventArgs e)
		{
			if(!string.Equals(tbPassword.Text, tbPasswordConfirm.Text) && !string.IsNullOrEmpty(tbPasswordConfirm.Text))
			{
				lbPasswordNotMatch.Visible = true;
			}
			else
			{
				lbPasswordNotMatch.Visible = false;
			}
		}
		private void tbPasswordConfirm_TextChanged(object sender, EventArgs e)
		{
			if (!string.Equals(tbPassword.Text, tbPasswordConfirm.Text) && !string.IsNullOrEmpty(tbPassword.Text))
			{
				lbPasswordNotMatch.Visible = true;
			}
			else
			{
				lbPasswordNotMatch.Visible = false;
			}
		}
		private void btnClose_MouseEnter(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.Red;
		}
		private void btnClose_MouseLeave(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.FromArgb(0, 160, 226);
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			try
			{
				this.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				drag = true;
				start = new Point(e.X, e.Y);
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				drag = false;
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (drag)
				{
					Point p = PointToScreen(e.Location);
					this.Location = new Point(p.X - start.X, p.Y - start.Y);
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		private bool CheckTextboxFilled()
		{
			foreach (Control control in pnlUserInput.Controls)
			{
				if (control is TextBox)
				{
					TextBox tb = control as TextBox;
					if (string.IsNullOrEmpty(tb.Text)) { return false; }
				}
			}
			return true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.CheckTextboxFilled())
				{
					throw new Exception("Please fill in all the information first.");
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void tbEmail_TextChanged(object sender, EventArgs e)
		{
			if (!(new Regex("[a-z0-9]+@[a-z]+\\.[a-z]{2,3}")).IsMatch(tbEmail.Text) && !string.IsNullOrEmpty(tbEmail.Text))
			{
				lbEmailInvalid.Visible = true;
			}
			else { lbEmailInvalid.Visible = false; }
		}

		private void tbZipcode_TextChanged(object sender, EventArgs e)
		{
			if (!(new Regex("^[1-9][0-9]{3} ?(?!sa|sd|ss|SA|SD|SS)([A-Z]{2}$|[a-z]{2}$)").IsMatch(tbZipcode.Text)) && !string.IsNullOrEmpty(tbZipcode.Text))
			{
				lbZipcodeInavlid.Visible = true;
			}
			else { lbZipcodeInavlid.Visible = false; }
		}

		private void tbHouseNumber_TextChanged(object sender, EventArgs e)
		{
			if(!(new Regex("^[0-9A-Za-z]+$").IsMatch(tbHouseNumber.Text)) && !string.IsNullOrEmpty(tbHouseNumber.Text))
			{
				lbInvalidHouseNumber.Visible = true;
			}
			else { lbInvalidHouseNumber.Visible = false; }
		}
	}
}
