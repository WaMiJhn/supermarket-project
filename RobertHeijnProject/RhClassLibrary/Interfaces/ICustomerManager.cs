using RhClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Interfaces
{
	public interface ICustomerManager
	{
		public int CreateCustomer(string firstname, string lastname, int accountid);
		public bool CreateAddress(string street, string housenumber, string zipcode, int personid);
		public Customer GetCustomerById(int id);
		public bool UpdateCustomer(int customerid, string firstname, string lastname, string street, string housenumber, string zipcode);
	}
}
