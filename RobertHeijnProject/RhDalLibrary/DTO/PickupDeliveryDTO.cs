using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DTO
{
	public class PickupDeliveryDTO : DeliveryOptionDTO
	{
		public DateTime PreferredTimeSlot { get; set; }
		public string Location { get; set; }
	}
}
