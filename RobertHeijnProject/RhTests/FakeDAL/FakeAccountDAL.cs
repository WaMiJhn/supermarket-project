using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhTests.FakeDAL
{
	public class FakeAccountDAL : IAccountDAL
	{
		private List<AccountDTO> _accounts;
		public FakeAccountDAL() 
		{
			_accounts = new List<AccountDTO>();
			AccountDTO account1 = new AccountDTO
			{
				Id = 1,
				Username = "test1",
				//unhashed pass = 123
				Password = "hA4whuwtyUgF4dJVCk+vyfn5MhCsTGiMSN8dk2f7HsI=",
				Salt = "MHWITZPalkr0JhZxksEh3kG0OYcbQEm7FDRkpqbJek86yX1pQBP0rghEp5WT5iGrmBgo+iSHTXd6UIRYkRmFMghWIW+ZkUNVTd1SR2udyBIoqRoYBWSwSBdJiSsp4t8N8NbCcWi67q9dvmS5x0c5hV41y6IMx3WGzGieYeQLZXk=",
				Email = "test1@mail.com"
			};
			AccountDTO account2 = new AccountDTO
			{
				Id = 2,
				Username = "test2",
				//unhashed pass = 1234
				Password = "XjS0Au3ERMrT/b+UEiuI8BRK190kFCWUssrZXVVHywY=",
				Salt = "3eVyLMnTzUsz1FRXBNWXmbve6CATzqPO3ttvse5gTYFaXH4ungFITOrDuT3Xs3mXyTmCZkh1FqmccpFHr0JQjsVvD05FWbztGAXI0ZmpnY0suhj1WQ9zVktCkafSQ4B9uySpcGgtp2WgB36l9fU35b+6vAO2JcjoJV6bR4NuXTs=",
				Email = "test2@mail.com"
			};
			_accounts.Add(account1);
		}

		public int CreateAccount(string username, string password, string salt, string email)
		{
			AccountDTO account = new AccountDTO
			{
				Id = new Random().Next(100,10000),
				Username = username,
				Password = password,
				Salt = salt,
				Email = email
			};
			_accounts.Add(account);
			return account.Id;
		}

		public AccountDTO GetAccountById(int id)
		{
			AccountDTO found = null;
			foreach(AccountDTO account in _accounts)
			{
				if (account.Id == id)
				{
					found = account;
				}
			}
			return found;
		}

		public AccountDTO GetAccountByUsername(string username)
		{
			throw new NotImplementedException();
		}

		public string GetSaltCustomer(string username)
		{
			foreach (var account in _accounts)
			{
				if (string.Equals(account.Username, username))
				{
					return account.Salt;
				}
			}
			return null;
		}

		public string GetSaltEmployee(string username)
		{
			foreach (var account in _accounts)
			{
				if (string.Equals(account.Username, username))
				{
					return account.Salt;
				}
			}
			return null;
		}

		public bool LoginValidationCustomer(string username, string password)
		{
			foreach (var account in _accounts)
			{
				if (string.Equals(account.Username, username) && string.Equals(account.Password, password))
				{
					return true;
				}
			}
			return false;
		}

		public bool LoginValidationEmployee(string username, string password)
		{
			foreach (var account in _accounts)
			{
				if (string.Equals(account.Username, username) && string.Equals(account.Password, password))
				{
					return true;
				}
			}
			return false;
		}

		public bool UpdateAccount(int accountid, string username, string email)
		{
			throw new NotImplementedException();
		}

		public bool UsernameCheck(string username)
		{
			foreach (var account in _accounts)
			{
				if (string.Equals(account.Username, username))
				{
					return true;
				}
			}
			return false;
		}
		public bool EmailCheck(string email)
		{
			foreach (var account in _accounts)
			{
				if (string.Equals(account.Email, email))
				{
					return true;
				}
			}
			return false;
		}
	}
}
