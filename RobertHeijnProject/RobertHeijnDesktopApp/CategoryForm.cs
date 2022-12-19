using RhClassLibrary.Interfaces;
using RhClassLibrary.Managers;
using RhDalLibrary.DAL;
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
	public partial class CategoryForm : Form
	{
		private readonly ICategoryManager categoryManager;
		public CategoryForm(ICategoryManager categoryManager)
		{
			InitializeComponent();

			this.categoryManager = categoryManager;

			this.LoadData();
		}

		public void LoadData()
		{
			dgvCategories.DataSource = categoryManager.GetCategoryDataTable(tbSearch.Text);
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			new CategoryContentForm(new ItemManager(new ItemDAL()), new CategoryManager(new CategoryDAL()), this).ShowDialog();
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadData();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void dataCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string columnid = dgvCategories.Columns[1].Name;
			if (e.ColumnIndex == 0)
			{
				new CategoryContentForm(new ItemManager(new ItemDAL()), new CategoryManager(new CategoryDAL()), this,
					categoryManager.FindCategory(Convert.ToInt32(dgvCategories.Rows[e.RowIndex].Cells[columnid].Value))).ShowDialog();
			}
		}
	}
}
