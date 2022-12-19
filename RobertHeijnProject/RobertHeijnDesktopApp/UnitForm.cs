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
	public partial class UnitForm : Form
	{
		private readonly IUnitManager unitManager;
		public UnitForm(IUnitManager unitManager)
		{
			InitializeComponent();

			this.unitManager = unitManager;

			this.LoadData();
		}

		public void LoadData()
		{
			dgvUnits.DataSource = unitManager.GetUnitDataTable(tbSearch.Text);
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void btnAddUnit_Click(object sender, EventArgs e)
		{
			new UnitContentForm(new UnitManager(new UnitDAL()), this).ShowDialog();
		}

		private void dgvUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string columnid = dgvUnits.Columns[1].Name;
			if (e.ColumnIndex == 0)
			{
				new UnitContentForm(new UnitManager(new UnitDAL()), this,
					unitManager.FindUnit(Convert.ToInt32(dgvUnits.Rows[e.RowIndex].Cells[columnid].Value))).ShowDialog();
			}
		}
	}
}
