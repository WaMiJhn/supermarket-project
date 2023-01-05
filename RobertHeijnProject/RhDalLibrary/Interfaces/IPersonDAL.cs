using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.Interfaces
{
    public interface IPersonDAL
    {
        //CreateCustomer and CreateEmployee are in the same class because they are both a person (inherit from the PersonClass),
        //CreateAddress is in this class because every person needs to have an address (1 to 1 relationship)
        public int CreateCustomer(string firstname, string lastname, int accountid);
        public int CreateEmployee(string firstname, string lastname, int accountid, decimal wage);
        public bool CreateAddress(string street, string housenumber, string zipcode, int personid);
		public CustomerDTO GetCustomerById(int id);
        public DataTable GetEmployeeDataTable(string search);
        public bool UpdatePerson(int personid, string firstname, string lastname);
        public bool UpdateAddress(int personid, string street, string housenumber, string zipcode);

	}
}
