using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
	public class Employee : Person
	{
		private decimal wage;
		public Employee(EmployeeDTO employeeDTO) : base(employeeDTO)
		{
			this.wage = employeeDTO.Wage;
		}

		public decimal Wage { get { return this.wage; } }
	}
}
