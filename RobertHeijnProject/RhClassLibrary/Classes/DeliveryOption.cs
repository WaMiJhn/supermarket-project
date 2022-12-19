using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhDalLibrary.DTO;

namespace RhClassLibrary.Classes
{
	public abstract class DeliveryOption
	{
		protected int id;
		protected DeliveryOption(HomeDeliveryDTO homeDeliveryDTO)
		{
			this.id = homeDeliveryDTO.Id;
		}
		protected DeliveryOption(PickupDeliveryDTO pickupDeliveryDTO)
		{
			this.id = pickupDeliveryDTO.Id;
		}
		protected DeliveryOption() { }
		public int Id { get { return id; } }
	}
}
