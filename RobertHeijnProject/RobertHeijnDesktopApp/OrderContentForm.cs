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
	public partial class OrderContentForm : Form
	{
		private bool drag = false;
		private Point start = new Point(0, 0);
		private readonly IOrderManager orderManager;
		private readonly Order selected;
		private readonly OrderForm orderForm;
		public OrderContentForm(IOrderManager orderManager, Order order, OrderForm orderForm)
		{
			InitializeComponent();

			this.orderManager = orderManager;
			this.selected = order;
			this.orderForm = orderForm;

			this.LoadData();
		}
		private void LoadData()
		{
			lbOrderId.Text = selected.Id.ToString();
			lbOrderDate.Text = selected.OrderDate.ToShortDateString();

			cbxOrderStatus.DisplayMember = "Name";
			cbxOrderStatus.DataSource = orderManager.GetAllOrderStatuses();

			cbxOrderStatus.SelectedIndex = cbxOrderStatus.FindStringExact(selected.OrderStatus.Name);
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (!orderManager.UpdateOrderStatus(selected, (OrderStatus)cbxOrderStatus.SelectedItem))
				{
					throw new Exception("Couldn't update status.");
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
			finally { orderForm.LoadData(); }
		}
	}
}
