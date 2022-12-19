using RhClassLibrary.Classes;
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
	public partial class UnitContentForm : Form
	{
		private bool drag = false;
		private Point start = new Point(0, 0);
		private Unit selected = null;
		private readonly UnitForm unitForm;
		private readonly IUnitManager unitManager;
		public UnitContentForm(IUnitManager unitManager, UnitForm unitForm)
		{
			InitializeComponent();

			this.unitManager = unitManager;
			this.unitForm = unitForm;
		}
		public UnitContentForm(IUnitManager unitManager, UnitForm unitForm, Unit unit)
		{
			InitializeComponent();

			this.unitManager = unitManager;
			this.unitForm = unitForm;
			this.selected = unit;

			this.FormLoadEditData();
		}
		private void FormLoadEditData()
		{
			lbUnit.Text = "Edit unit";
			lbId.Text = selected.Id.ToString();
			lbUnitId.Visible = true;
			lbId.Visible = true;
			tbName.Text = selected.Name;
			btnSave.Text = "Save changes";
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(tbName.Text))
				{
					throw new Exception("Please fill in a name for the unit.");
				}
				if (selected == null)
				{
					if (!unitManager.CreateUnit(tbName.Text))
					{
						throw new Exception("Unit could not be created.");
					}
					MessageBox.Show("Unit successfully created.");
				}
				else
				{
					if (!unitManager.UpdateUnit(selected, tbName.Text))
					{
						throw new Exception("Unit could not be updated.");
					}
					MessageBox.Show("Unit successfully updated.");
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
			finally { unitForm.LoadData(); }
		}
	}
}
