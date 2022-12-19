using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.Interfaces
{
	public interface IOrderDAL
	{
		public int CreateOrder(DateTime date, int deliveryoptionid, int orderstatusid, int? customerid);
		public bool CreateOrderLine(int orderid, int itemid, int quantity);
		public int CreateHomeDelivery(DateTime deliverDateTime);
		public int CreatePickupDelivery(string location, DateTime preferredTimeSlot);
		public DataTable GetOrderDataTable(string search);
		public OrderDTO FindOrder(int id);
		public List<OrderStatusDTO> GetAllOrderStatuses();
		public bool UpdateOrderStatus(int orderid, int orderstatusid);
	}
}
