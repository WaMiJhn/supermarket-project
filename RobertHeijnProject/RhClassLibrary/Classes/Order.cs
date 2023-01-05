using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
	public class Order
	{
		private int id;
		private DateTime orderdate;
		private DeliveryOption deliveryOption;
		private OrderStatus orderStatus;
		public Order(OrderDTO orderDTO)
		{
			this.id = orderDTO.Id;
			this.orderdate = orderDTO.OrderDate;
			if(orderDTO.DeliveryOption.GetType() == typeof(HomeDeliveryDTO)) { this.deliveryOption = new HomeDelivery((HomeDeliveryDTO)orderDTO.DeliveryOption); }
			else if (orderDTO.DeliveryOption.GetType() == typeof(PickupDeliveryDTO)) { this.deliveryOption = new PickupDelivery((PickupDeliveryDTO)orderDTO.DeliveryOption); }
			this.orderStatus = new OrderStatus(orderDTO.OrderStatus);
		}

		public int Id { get { return id; } }
		public DateTime OrderDate { get { return orderdate; } }
		public DeliveryOption DeliveryOption { get { return deliveryOption; } }
		public OrderStatus OrderStatus { get { return orderStatus; } }
	}
}
