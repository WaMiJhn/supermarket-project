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
	public partial class OrderForm : Form
	{
		private readonly IOrderManager orderManager;
		public OrderForm(IOrderManager orderManager)
		{
			InitializeComponent();

			this.orderManager = orderManager;

			this.LoadData();
		}
		public void LoadData()
		{
			dgvOrders.DataSource = orderManager.GetOrderDataTable(tbSearch.Text);
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}
		private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string columnid = dgvOrders.Columns[1].Name;
			if (e.ColumnIndex == 0 )
			{
				new OrderContentForm(new OrderManager(new OrderDAL()), orderManager.FindOrder(Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[columnid].Value)), this).ShowDialog();

			}

		}
	}
}
