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
		//The reason why I put the CreateHomeDelivery() and CreatePickupDelivery() in this interface is because Order always has a deliveryoption and everything belongs to an order
		//and every order needs to have 1 orderstatus and 1 deliveryoption (both are 1 to 1 relationships)
		//If the deliveryoptions would be extended, as well as the orderstatuses it should receive its own DAL class, as it is not the case here since deliveryoptions and orderstatuses
		//are both very limited, it is not necessary to create a new class for it.
		public int CreateOrder(DateTime date, int deliveryoptionid, int orderstatusid, int? customerid);
		public bool CreateOrderLine(int orderid, int itemid, int quantity);
		public int CreateHomeDelivery(DateTime deliverDateTime);
		public int CreatePickupDelivery(string location, DateTime preferredTimeSlot);
		public DataTable GetOrderDataTable(string search);
		public OrderDTO FindOrder(int id);
		public List<OrderStatusDTO> GetAllOrderStatuses();
		public int GetCountHomeDelivery(DateTime dateTime);
		public Dictionary<int, int> GetItemsFromOrder(int orderid);
		public List<OrderDTO> GetAllPickupDeliveryOrdersFromCustomer(int customerid);
		public List<OrderDTO> GetAllHomeDeliveryOrdersFromCustomer(int customerid);
		public bool UpdateOrderStatus(int orderid, int orderstatusid);
	}
}
