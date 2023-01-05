using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhTests.FakeDAL
{
	public class FakeOrderDAL : IOrderDAL
	{
		private List<OrderDTO> _orders;
		private List<DeliveryOptionDTO> _deliveryOptions;
		public FakeOrderDAL() 
		{
			_orders = new List<OrderDTO>();
			_deliveryOptions = new List<DeliveryOptionDTO>();
		}

		public int CreateHomeDelivery(DateTime deliverDateTime)
		{
			HomeDeliveryDTO homeDeliveryDTO = new HomeDeliveryDTO
			{
				DeliverDateTime = deliverDateTime,
				Id = new Random().Next(100, 10000)
			};
			_deliveryOptions.Add(homeDeliveryDTO);
			return homeDeliveryDTO.Id;
		}

		public int CreateOrder(DateTime date, int deliveryoptionid, int orderstatusid, int? customerid)
		{
			OrderDTO orderDTO = new OrderDTO
			{
				Id = new Random().Next(100, 10000),
				OrderDate = date,
				OrderStatus = new OrderStatusDTO { Id = 1, Name = "in progress"},
				DeliveryOption = new HomeDeliveryDTO { Id = CreateHomeDelivery(new DateTime(2022, 12, 23, 15, 0, 0)), DeliverDateTime = new DateTime(2022, 12, 23, 15, 0, 0) }
			};
			return orderDTO.Id;
		}

		public bool CreateOrderLine(int orderid, int itemid, int quantity)
		{
			throw new NotImplementedException();
		}

		public int CreatePickupDelivery(string location, DateTime preferredTimeSlot)
		{
			PickupDeliveryDTO pickupDeliveryDTO = new PickupDeliveryDTO
			{
				Id = new Random().Next(100, 10000),
				Location = location,
				PreferredTimeSlot = preferredTimeSlot
			};
			_deliveryOptions.Add(pickupDeliveryDTO);
			return pickupDeliveryDTO.Id;
		}

		public OrderDTO FindOrder(int id)
		{
			throw new NotImplementedException();
		}

		public List<OrderDTO> GetAllHomeDeliveryOrdersFromCustomer(int customerid)
		{
			throw new NotImplementedException();
		}

		public List<OrderStatusDTO> GetAllOrderStatuses()
		{
			throw new NotImplementedException();
		}

		public List<OrderDTO> GetAllPickupDeliveryOrdersFromCustomer(int customerid)
		{
			throw new NotImplementedException();
		}

		public int GetCountHomeDelivery(DateTime dateTime)
		{
			int sum = 0;
			foreach(var homedelivery in _deliveryOptions)
			{
				if (homedelivery.GetType() == typeof(HomeDeliveryDTO))
				{
					HomeDeliveryDTO homeDeliveryDTO = (HomeDeliveryDTO)homedelivery;
					if(homeDeliveryDTO.DeliverDateTime == dateTime)
					{
						sum++;
					}
				}
			}
			return sum;
		}

		public Dictionary<int, int> GetItemsFromOrder(int orderid)
		{
			throw new NotImplementedException();
		}

		public DataTable GetOrderDataTable(string search)
		{
			throw new NotImplementedException();
		}

		public bool UpdateOrderStatus(int orderid, int orderstatusid)
		{
			throw new NotImplementedException();
		}
	}
}
