using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DTO
{
	public class HomeDeliveryDTO : DeliveryOptionDTO
	{
		public DateTime DeliverDateTime { get; set; }
	}
}
