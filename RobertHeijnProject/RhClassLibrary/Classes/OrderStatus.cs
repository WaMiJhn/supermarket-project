using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhDalLibrary.DTO;

namespace RhClassLibrary.Classes
{
	public class OrderStatus : Attribute
	{
		public OrderStatus(OrderStatusDTO orderStatusDTO) : base(orderStatusDTO){ }
	}
}
