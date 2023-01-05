using RhClassLibrary.Interfaces;
using RhClassLibrary.Classes;
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
using System.Reflection;

namespace RobertHeijnDesktopApp
{
	public partial class ItemForm : Form
	{
		private readonly IItemManager itemManager;
		private readonly ICategoryManager categoryManager;
		public ItemForm(IItemManager itemManager, ICategoryManager categoryManager)
		{
			InitializeComponent();

			this.itemManager = itemManager;
			this.categoryManager = categoryManager;

			this.LoadData();
		}
		public void LoadData()
		{
			dgvItems.DataSource = itemManager.GetItemDataTable(tbSearch.Text);
		}
		private void btnAddItem_Click(object sender, EventArgs e)
		{
			new ItemContentForm(new ItemManager(new ItemDAL()), this, new CategoryManager(new CategoryDAL()), new UnitManager(new UnitDAL())).ShowDialog();
		}

		private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string columnId = dgvItems.Columns[1].Name;
			if (e.ColumnIndex == 0)
			{
				new ItemContentForm(new ItemManager(new ItemDAL()), this, 
					itemManager.FindItem(Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells[columnId].Value)), 
					new CategoryManager(new CategoryDAL()),
					new UnitManager(new UnitDAL())).ShowDialog();
			}
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}
	}
}
