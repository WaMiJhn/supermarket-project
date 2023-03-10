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
		public string GenerateSalt();
		public string HashPassword(string password);
		public int CreateAccount(string username, string password, string email);
		public bool LoginValidationEmployee(string username, string password);
		public bool LoginValidationCustomer(string username, string password);
		public Account GetAccountById(int id);
		public Account GetAccountByUsername(string username);
		public bool UpdateAccount(Account account, string username, string email);
	}
}
