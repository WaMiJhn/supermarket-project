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
	public partial class CategoryContentForm : Form
	{
		private bool drag = false;
		private Point start = new Point(0, 0);
		private readonly Category selected = null;
		private readonly IItemManager itemManager;
		private readonly ICategoryManager categoryManager;
		private readonly CategoryForm categoryForm;
		public CategoryContentForm(IItemManager itemManager, ICategoryManager categoryManager, CategoryForm categoryForm)
		{
			InitializeComponent();

			this.itemManager = itemManager;
			this.categoryManager = categoryManager;
			this.categoryForm = categoryForm;

			this.FormLoadAddCategory();
		}
		public CategoryContentForm(IItemManager itemManager, ICategoryManager categoryManager, CategoryForm categoryForm, Category category)
		{
			InitializeComponent();

			this.itemManager = itemManager;
			this.categoryManager = categoryManager;
			this.selected = category;
			this.categoryForm = categoryForm;

			this.FormLoadEditCategory();
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			try
			{
				this.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnClose_MouseEnter(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.Red;
		}

		private void btnClose_MouseLeave(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.FromArgb(0, 160, 226);
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
		private void LoadCombobox()
		{
			cbxCategory.DisplayMember = "Name";
			cbxCategory.DataSource = categoryManager.GetAllCategories();
			cbxCategory.SelectedIndex = -1;
		}
		private void FormLoadAddCategory()
		{
			this.LoadCombobox();
		}
		private void FormLoadEditCategory()
		{
			lbCategory.Text = "Edit category";
			lbCategoryId.Visible = true;
			lbId.Text = selected.Id.ToString();
			lbId.Visible = true;
			tbName.Text = selected.Name;
			btnSave.Text = "Save changes";

			this.LoadCombobox();
			if (categoryManager.FindParentCategory(selected) != null)
			{
				cbxCategory.SelectedIndex = cbxCategory.FindStringExact(categoryManager.FindParentCategory(selected).Name);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(tbName.Text))
				{
					throw new Exception("Please fill in a name for the category.");
				}
				if (selected == null)
				{
					if (!categoryManager.CreateCategory(tbName.Text, (Category)cbxCategory.SelectedItem))
					{
						throw new Exception("Category could not be created.");
					}
					MessageBox.Show("Category successfully created.");
				}
				else
				{
					if (!categoryManager.UpdateCategory(selected, tbName.Text, (Category)cbxCategory.SelectedItem))
					{
						throw new Exception("Category could not be updated.");
					}
					MessageBox.Show("Category successfully updated.");
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
			finally { categoryForm.LoadData(); }
		}
	}
}
