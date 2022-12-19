using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DTO
{
	public class OrderDTO
	{
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public DeliveryOptionDTO DeliveryOption { get; set; }
		public OrderStatusDTO OrderStatus { get; set; }
	}
}
