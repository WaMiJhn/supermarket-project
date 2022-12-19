using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using RhDalLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Managers
{
	public class PersonManager : ICustomerManager
	{
		private readonly IPersonDAL personDAL;
		public PersonManager(IPersonDAL personDAL)
		{
			this.personDAL = personDAL;
		}

		public Customer GetCustomerById(int id)
		{
			try
			{
				return new Customer(personDAL.GetCustomerById(id));
			}
			catch (Exception ex) { throw; }
		}
	}
}
