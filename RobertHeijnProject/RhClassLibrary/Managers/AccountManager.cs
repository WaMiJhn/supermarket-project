﻿using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Managers
{
	public class AccountManager : IAccountManager
	{
		private readonly IAccountDAL accountDAL;
		public AccountManager(IAccountDAL accountDAL)
		{
			this.accountDAL = accountDAL;
		}
		private string GenerateSalt()
		{
			byte[] saltAsBytes = new byte[128];
			RandomNumberGenerator.Create().GetBytes(saltAsBytes);
			return Convert.ToBase64String(saltAsBytes);
		}
		private string HashPassword(string password)
		{
			var asByteArray = Encoding.UTF8.GetBytes(password);
			return Convert.ToBase64String(SHA256.Create().ComputeHash(asByteArray));
		}
		public bool CreateAccount(string username, string password, string email)
		{
			try
			{
				string salt = this.GenerateSalt();
				string saltAndPass = string.Concat(password, salt);
				string hashedPass = this.HashPassword(saltAndPass);
				return accountDAL.CreateAccount(username, hashedPass, salt, email);
			}
			catch (Exception ex) { throw; }
		}
		public bool LoginValidationEmployee(string username, string password)
		{
			try
			{
				string salt = accountDAL.GetSaltEmployee(username);
				string saltAndPass = string.Concat(password, salt);
				string hashedPass = this.HashPassword(saltAndPass);

				return accountDAL.LoginValidationEmployee(username, hashedPass);
			}
			catch (Exception ex) { throw; }
		}
		public bool LoginValidationCustomer(string username, string password)
		{
			try
			{
				string salt = accountDAL.GetSaltCustomer(username);
				string saltAndPass = string.Concat(password, salt);
				string hashedPass = this.HashPassword(saltAndPass);

				return accountDAL.LoginValidationCustomer(username, hashedPass);
			}
			catch (Exception ex) { throw; }
		}
		public Account GetAccountById(int id)
		{
			try
			{
				return new Account(accountDAL.GetAccountById(id));
			}
			catch (Exception ex) { throw; }
		}
		public Account GetAccountByUsername(string username)
		{
			try
			{
				return new Account(accountDAL.GetAccountByUsername(username));
			}
			catch (Exception ex) { throw; }
		}
	}
}
