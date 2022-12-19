using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
	public abstract class Person
	{
		protected int id;
		protected string firstName;
		protected string lastName;
		protected Account account;
		protected Address address;
		public Person(CustomerDTO customerDTO)
		{
			this.id = customerDTO.Id;
			this.firstName = customerDTO.FirstName;
			this.lastName = customerDTO.LastName;
			this.account = new Account(customerDTO.Account);
			this.address = new Address(customerDTO.Address);
		}
		public Person(EmployeeDTO employeeDTO)
		{
			this.id = employeeDTO.Id;
			this.firstName = employeeDTO.FirstName;
			this.lastName = employeeDTO.LastName;
			this.account = new Account(employeeDTO.Account);
			this.address = new Address(employeeDTO.Address);
		}

		public int Id { get { return id; } }
		public string FirstName { get { return firstName;} }
		public string LastName { get { return lastName;} }
		public Account Account { get { return account; } }
		public Address Address { get { return address; } }
	}
}
