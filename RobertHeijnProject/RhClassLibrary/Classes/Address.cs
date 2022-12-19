using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
	public class Address
	{
		private int id;
		private string street;
		private string housenumber;
		private string zipcode;
		public Address(AddressDTO addressDTO)
		{
			this.id = addressDTO.Id;
			this.street = addressDTO.Street;
			this.housenumber = addressDTO.HouseNumber;
			this.zipcode = addressDTO.ZipCode;
		}

		public int Id { get { return id; } }
		public string Street { get { return street; } }
		public string Housenumber { get { return housenumber; } }
		public string Zipcode { get { return zipcode; } }
	}
}
