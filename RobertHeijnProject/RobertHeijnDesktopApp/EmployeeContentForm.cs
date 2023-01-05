using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
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
		private Regex regexEmail; /*= new Regex("[a-z0-9]+@[a-z]+\\.[a-z]{2,3}");*/
		private Regex regexZipcode; /*= new Regex("^[1-9][0-9]{3} ?(?!sa|sd|ss|SA|SD|SS)([A-Z]{2}$|[a-z]{2}$)");*/
		private Regex regexHouseNumber; /*= new Regex("^[1-9]\\d*(?:[ -]?(?:[a-zA-Z]+|[1-9]\\d*))?$");*/

        private readonly IEmployeeManager employeeManager;
        private readonly IAccountManager accountManager;

        public EmployeeContentForm(IEmployeeManager employeeManager, IAccountManager accountManager)
		{
			InitializeComponent();

			this.employeeManager = employeeManager;
			this.accountManager = accountManager;

			this.LoadRegexes();
		}
		private void LoadRegexes()
		{
			regexEmail = new Regex(RegexInput.RegexEmail);
			regexZipcode = new Regex(RegexInput.RegexZipcode);
			regexHouseNumber = new Regex(RegexInput.RegexHouseNumber);
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
				else if(!string.Equals(tbPassword.Text, tbPasswordConfirm.Text))
				{
					throw new Exception("Passwords don't match.");
				}
				else if (!regexEmail.IsMatch(tbEmail.Text))
				{
					throw new Exception("Please fill in a valid email.");
				}
				else if (!regexHouseNumber.IsMatch(tbHouseNumber.Text))
				{
					throw new Exception("Please fill in a valid house number.");
				}
				else if (!regexZipcode.IsMatch(tbZipcode.Text))
				{
					throw new Exception("Please fill in a valid zipcode.");
				}
				if (!employeeManager.CreateAddress(tbStreet.Text, tbHouseNumber.Text, tbZipcode.Text,
					employeeManager.CreateEmployee(tbFirstName.Text, tbLastName.Text,
					accountManager.CreateAccount(tbUsername.Text, tbPassword.Text, tbEmail.Text), numWage.Value)))
				{
					throw new Exception("Employee could not be added, please try again.");
				}
				else
				{
					MessageBox.Show("Employee successfully added.");
					this.Close();
				}

			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void tbEmail_TextChanged(object sender, EventArgs e)
		{
			if (!(regexEmail).IsMatch(tbEmail.Text) && !string.IsNullOrEmpty(tbEmail.Text))
			{
				lbEmailInvalid.Visible = true;
			}
			else { lbEmailInvalid.Visible = false; }
		}

		private void tbZipcode_TextChanged(object sender, EventArgs e)
		{
			if (!regexZipcode.IsMatch(tbZipcode.Text) && !string.IsNullOrEmpty(tbZipcode.Text))
			{
				lbZipcodeInavlid.Visible = true;
			}
			else { lbZipcodeInavlid.Visible = false; }
		}

		private void tbHouseNumber_TextChanged(object sender, EventArgs e)
		{
			if(!regexHouseNumber.IsMatch(tbHouseNumber.Text) && !string.IsNullOrEmpty(tbHouseNumber.Text))
			{
				lbInvalidHouseNumber.Visible = true;
			}
			else { lbInvalidHouseNumber.Visible = false; }
		}
	}
}
