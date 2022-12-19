﻿using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.Interfaces
{
	public interface IAccountDAL
	{
		public bool CreateAccount(string username, string password, string salt, string email);
		public string GetSaltEmployee(string username);
		public string GetSaltCustomer(string username);
		public bool LoginValidationEmployee(string username, string password);
		public bool LoginValidationCustomer(string username, string password);
		public AccountDTO GetAccountById(int id);
		public AccountDTO GetAccountByUsername(string username);
	}
}
