using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using RhClassLibrary.Managers;

namespace RobertHeijnDesktopApp
{
	public partial class ItemContentForm : Form
	{
		private bool drag = false;
		private Point start = new Point(0, 0);
		private Item selected = null;
		private readonly IItemManager itemManager;
		private readonly ICategoryManager categoryManager;
		private readonly IUnitManager unitManager;
		private readonly ItemForm itemForm;
		public ItemContentForm(IItemManager itemManager, ItemForm itemForm, ICategoryManager categoryManager, IUnitManager unitManager)
		{
			InitializeComponent();

			this.categoryManager = categoryManager;
			this.itemManager = itemManager;
			this.itemForm = itemForm;
			this.unitManager = unitManager;

			this.FormLoadAddItem();
		}
		public ItemContentForm(IItemManager itemManager, ItemForm itemForm, Item selected, ICategoryManager categoryManager, IUnitManager unitManager)
		{
			InitializeComponent();

			this.categoryManager = categoryManager;
			this.itemManager = itemManager;
			this.itemForm = itemForm;
			this.selected = selected;
			this.unitManager = unitManager;

			this.FormLoadEditItem();
		}
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
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
		private void LoadComboboxes()
		{
			cbxCategory.DisplayMember = "Name";
			cbxCategory.DataSource = categoryManager.GetAllCategories();
			cbxCategory.SelectedIndex = -1;

			cbxUnit.DisplayMember = "Name";
			cbxUnit.DataSource = unitManager.GetAllUnits();
			cbxUnit.SelectedIndex = -1;
		}
		private void FormLoadAddItem()
		{
			this.LoadComboboxes();
		}
		private void FormLoadEditItem()
		{
			lbItem.Text = "Edit item";
			btnSave.Text = "Save changes";
			lbItemId.Visible = true;
			lbId.Text = selected.Id.ToString();
			lbId.Visible = true;
			tbName.Text = selected.Name;
			chxAvailable.Checked = selected.Available;
			chxAvailable.Visible = true;
			numPrice.Value = selected.Price;
			tbImageSrc.Text = selected.ImageSource;

			this.LoadComboboxes();
			cbxCategory.SelectedIndex = cbxCategory.FindStringExact(categoryManager.GetCategoryFromItem(selected).Name);
			cbxUnit.SelectedIndex = cbxUnit.FindStringExact(unitManager.GetUnitFromItem(selected).Name);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbImageSrc.Text) || cbxCategory.SelectedIndex == -1 || cbxUnit.SelectedIndex == -1)
				{
					throw new Exception("Please fill in all the necessary information.");
				}
				else if (numPrice.Value == 0)
				{
					throw new Exception("Price cannot be equal to zero");
				}
				if (selected == null)
				{
					if (!itemManager.CreateItem(tbName.Text, numPrice.Value, tbImageSrc.Text, (Unit)cbxUnit.SelectedItem, (Category)cbxCategory.SelectedItem))
					{
						throw new Exception("Item could not be created.");
					}
					MessageBox.Show("Item successfully created.");
				}
				else
				{
					if (!itemManager.UpdateItem(selected.Id, tbName.Text, numPrice.Value, tbImageSrc.Text, (Unit)cbxUnit.SelectedItem, (Category)cbxCategory.SelectedItem, chxAvailable.Checked))
					{
						throw new Exception("Item could not be updated.");
					}
					MessageBox.Show("Item successfully updated.");
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
			finally { itemForm.LoadData();}
		}
	}
}
