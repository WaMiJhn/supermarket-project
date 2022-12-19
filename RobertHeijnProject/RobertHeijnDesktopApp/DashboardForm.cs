using RhClassLibrary.Managers;
using RhDalLibrary.DAL;
using RobertHeijnDesktopApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobertHeijnDesktopApp
{
	public partial class DashboardForm : Form
	{
		private Button currentbutton;
		private Form activeForm;
		private bool drag = false;
		private Point start = new Point(0, 0);

		public DashboardForm()
		{
			InitializeComponent();

			OpenChildForm(new ItemForm(new ItemManager(new ItemDAL()), new CategoryManager(new CategoryDAL())), btnItems);
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
				DialogResult result = MessageBox.Show("Are you sure you would like to exit the program?", "", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes) { Application.Exit(); }
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		private void HighlightButton(object sender)
		{
			if (sender != null)
			{
				if (currentbutton != (Button)sender)
				{
					UnHighlightButton();
					currentbutton = (Button)sender;
					currentbutton.BackColor = Color.FromArgb(0, 142, 207);
				}
			}
		}
		private void UnHighlightButton()
		{
			foreach (Control prevBtn in pnlNavigation.Controls)
			{
				if (prevBtn.GetType() == typeof(Button))
				{
					if (prevBtn.Name != btnLogout.Name)
					{
						prevBtn.BackColor = Color.FromArgb(51, 51, 76);
					}
				}
			}
		}
		private void OpenChildForm(Form childform, object sender)
		{
			try
			{
				if (activeForm != null)
				{
					activeForm.Close();
				}
				HighlightButton(sender);
				activeForm = childform;
				childform.TopLevel = false;
				childform.FormBorderStyle = FormBorderStyle.None;
				childform.Dock = DockStyle.Fill;
				this.pnlDesktop.Controls.Add(childform);
				this.pnlDesktop.Tag = childform;
				childform.BringToFront();
				childform.Show();
			}
			catch (Exception ex){ MessageBox.Show(ex.Message); }
		}
		private void btnLogout_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult result = MessageBox.Show("Are you sure you would like to log out?", "", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes) { this.Hide(); new LoginForm(new AccountManager(new AccountDAL())).Show(); }
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
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

		private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				drag = false;
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnItems_Click(object sender, EventArgs e)
		{
			OpenChildForm(new ItemForm(new ItemManager(new ItemDAL()), new CategoryManager(new CategoryDAL())), sender);
		}

		private void btnOrders_Click(object sender, EventArgs e)
		{
			OpenChildForm(new OrderForm(new OrderManager(new OrderDAL())), sender);
		}

		private void btnCategories_Click(object sender, EventArgs e)
		{
			OpenChildForm(new CategoryForm(new CategoryManager(new CategoryDAL())), sender);
		}

		private void btnUnits_Click(object sender, EventArgs e)
		{
			OpenChildForm(new UnitForm(new UnitManager(new UnitDAL())), sender);
		}
		private void btnEmployees_Click(object sender, EventArgs e)
		{
			OpenChildForm(new EmployeeForm(), sender);
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			try
			{
				if (WindowState == FormWindowState.Normal)
				{ WindowState = FormWindowState.Maximized; btnMaximize.BackgroundImage = Resources.windows_restore_icon; }
				else { WindowState = FormWindowState.Normal; btnMaximize.BackgroundImage = Resources.window_maximize_icon; }
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
	}
}
