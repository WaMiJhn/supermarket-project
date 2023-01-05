using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Interfaces
{
    public interface IEmployeeManager
    {
        public int CreateEmployee(string firstname, string lastname, int accountid, decimal wage);
        public bool CreateAddress(string street, string housenumber, string zipcode, int personid);
        public DataTable GetEmployeeDataTable(string search);
    }
}
