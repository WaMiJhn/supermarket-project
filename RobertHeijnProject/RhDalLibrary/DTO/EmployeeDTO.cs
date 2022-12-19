using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DTO
{
	public class EmployeeDTO
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Wage { get; set; }
		public AccountDTO Account { get; set; }
		public AddressDTO Address { get; set; }
	}
}
