using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
	public class Customer : Person
	{
		public Customer(CustomerDTO customerDTO) : base(customerDTO) { }
	}
}
