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
		public Customer GetCustomerById(int id);
	}
}
