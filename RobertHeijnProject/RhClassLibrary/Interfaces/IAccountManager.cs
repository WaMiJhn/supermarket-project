using RhClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Interfaces
{
	public interface IAccountManager
	{
		public bool CreateAccount(string username, string password, string email);
		public bool LoginValidationEmployee(string username, string password);
		public bool LoginValidationCustomer(string username, string password);
		public Account GetAccountById(int id);
		public Account GetAccountByUsername(string username);
	}
}
