using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
	public class PickupDelivery : DeliveryOption
	{
		private DateTime preferredTimeSlot;
		private string location;
		public PickupDelivery(PickupDeliveryDTO pickupDeliveryDTO) : base(pickupDeliveryDTO)
		{
			this.preferredTimeSlot = pickupDeliveryDTO.PreferredTimeSlot;
			this.location = pickupDeliveryDTO.Location;
		}
		public string Location { get { return location; } }
		public DateTime PreferredTimeSlot { get { return preferredTimeSlot; } }
	}
}
