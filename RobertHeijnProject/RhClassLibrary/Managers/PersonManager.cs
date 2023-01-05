using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Managers
{
    public class PersonManager : ICustomerManager, IEmployeeManager
	{
		private readonly IPersonDAL personDAL;
		public PersonManager(IPersonDAL personDAL)
		{
			this.personDAL = personDAL;
		}
		public int CreateCustomer(string firstname, string lastname, int accountid)
		{
			try
			{
				return personDAL.CreateCustomer(firstname, lastname, accountid);
			}
			catch (Exception ex) { throw; }
		}
        public int CreateEmployee(string firstname, string lastname, int accountid, decimal wage)
		{
			try
			{
				return personDAL.CreateEmployee(firstname, lastname, accountid, wage);
			}
			catch (Exception ex) { throw; }
		}

		public bool CreateAddress(string street, string housenumber, string zipcode, int personid)
		{
			try
			{
				return personDAL.CreateAddress( street, housenumber, zipcode, personid);
			}
			catch (Exception ex) { throw; }
		}

		public Customer GetCustomerById(int id)
		{
			try
			{
				return new Customer(personDAL.GetCustomerById(id));
			}
			catch (Exception ex) { throw; }
		}
        public DataTable GetEmployeeDataTable(string search)
		{
			try
			{
				return personDAL.GetEmployeeDataTable(search);
			}
			catch (Exception ex) { throw; }
		}
		public bool UpdateCustomer(int customerid, string firstname, string lastname, string street, string housenumber, string zipcode)
		{
			try
			{
				return personDAL.UpdatePerson(customerid, firstname, lastname) && personDAL.UpdateAddress(customerid, street, housenumber, zipcode);
			}
			catch (Exception ex) { throw; }
		}
	}
}
