using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
	public class HomeDelivery : DeliveryOption
	{
		private DateTime deliverDateTime;
		public HomeDelivery(HomeDeliveryDTO homeDeliveryDTO) : base(homeDeliveryDTO)
		{
			this.deliverDateTime = homeDeliveryDTO.DeliverDateTime;
		}
		public DateTime DeliverDateTime { get { return deliverDateTime; } }
	}
}
