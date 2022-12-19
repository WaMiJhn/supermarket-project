using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DAL
{
	public interface IPersonDAL
	{
		public CustomerDTO GetCustomerById(int id);
	}
}
