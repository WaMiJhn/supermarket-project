using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Managers
{
	public class OrderManager : IOrderManager
	{
		private readonly IOrderDAL orderDAL;
		public OrderManager(IOrderDAL orderDAL)
		{
			this.orderDAL = orderDAL;
		}
		public bool CreateOrderWithShoppingCart(Dictionary<int, int> shoppingcart, int deliveryoptionid, int? customerid)
		{
			try
			{
				int orderStatusPending = 1;
				int orderid;
				if (customerid != null)
				{
					orderid = orderDAL.CreateOrder(DateTime.Now, deliveryoptionid, orderStatusPending, customerid);
				}
				else { orderid = orderDAL.CreateOrder(DateTime.Now, deliveryoptionid, orderStatusPending, null); }
				foreach(var pair in shoppingcart) 
				{
					orderDAL.CreateOrderLine(orderid, pair.Key, pair.Value);
				}
				return true;
			}
			catch (Exception ex) { throw; }
		}
		public int CreateHomeDelivery(DateTime deliverDateTime)
		{
			try
			{
				return orderDAL.CreateHomeDelivery(deliverDateTime);
			}
			catch (Exception ex) { throw; }
		}
		public int CreatePickupDelivery(string location, DateTime preferredTimeSlot)
		{
			try
			{
				return orderDAL.CreatePickupDelivery(location, preferredTimeSlot);
			}
			catch (Exception ex) { throw; }
		}
		public DataTable GetOrderDataTable(string search)
		{
			try
			{
				return orderDAL.GetOrderDataTable(search);
			}
			catch(Exception ex) { throw; }
		}
		public Order FindOrder(int id)
		{
			try
			{
				return new Order(orderDAL.FindOrder(id));
			}
			catch (Exception ex) { throw; }
		}
		public List<OrderStatus> GetAllOrderStatuses()
		{
			try
			{
				List<OrderStatus> orderStatuses = new List<OrderStatus>();
				foreach (var orderStatus in orderDAL.GetAllOrderStatuses())
				{
					orderStatuses.Add(new OrderStatus(orderStatus));
				}
				return orderStatuses;
			}
			catch (Exception ex) { throw; }
		}
		public bool UpdateOrderStatus(Order order, OrderStatus orderStatus)
		{
			try
			{
				return orderDAL.UpdateOrderStatus(order.Id, orderStatus.Id);
			}
			catch (Exception ex) { throw; }
		}
	}
}
