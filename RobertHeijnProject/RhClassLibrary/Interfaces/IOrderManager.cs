using RhClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Interfaces
{
	public interface IOrderManager
	{
		public bool CreateOrderWithShoppingCart(Dictionary<int, int> shoppingcart, int deliveryoptionid, int? customerid);
		public int CreateHomeDelivery(DateTime deliverDateTime);
		public int CreatePickupDelivery(string location, DateTime preferredTimeSlot);
		public DataTable GetOrderDataTable(string search);
		public Order FindOrder(int id);
		public List<OrderStatus> GetAllOrderStatuses();
		public bool UpdateOrderStatus(Order order, OrderStatus orderStatus);
	}
}
