using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DAL
{
	public class AccountDAL : BaseDAL, IAccountDAL
	{
		//create
		public bool CreateAccount(string username, string password, string salt, string email)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@username", username),
					new SqlParameter("@password", password),
					new SqlParameter("@salt", salt),
					new SqlParameter("@email", email) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("insert into accountTbl (Username, Password, Salt, Email) " +
						"values (@username, @password, @salt, @email)", sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { return false; }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		//read
		public string GetSaltEmployee(string username)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@username", username) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select a.Salt from accountTbl as a " +
						"inner join personTbl as p on p.AccountId = a.id " +
						"inner join employeeTbl as e on e.EmployeeId = p.id " +
						"where username = @username", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							return Convert.ToString(dr["Salt"]);
						}
						else { throw new Exception("An account with the username: " + username + " could not be found, please try again."); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public string GetSaltCustomer(string username)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@username", username) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select a.Salt from accountTbl as a " +
						"inner join personTbl as p on p.AccountId = a.id " +
						"inner join customerTbl as c on c.CustomerId = p.id " +
						"where username = @username", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							return Convert.ToString(dr["Salt"]);
						}
						else { throw new Exception("An account with the username: " + username + " could not be found, please try again."); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public bool LoginValidationEmployee(string username, string password)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@username", username),
					new SqlParameter("@password", password) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select count(*) from accountTbl as a " +
						"inner join personTbl as p on p.AccountId = a.id " +
						"inner join employeeTbl as e on e.EmployeeId = p.id " +
						"where a.username = @username and a.password = @password", sp);
					return ((int)cmd.ExecuteScalar() == 1);
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public bool LoginValidationCustomer(string username, string password)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@username", username),
					new SqlParameter("@password", password) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select count(*) from accountTbl as a " +
						"inner join personTbl as p on p.AccountId = a.id " +
						"inner join customerTbl as c on c.CustomerId = p.id " +
						"where a.username = @username and a.password = @password", sp);
					return ((int)cmd.ExecuteScalar() == 1);
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public AccountDTO GetAccountById(int id)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", id) };
				if (OpenConnection()) 
				{
					SqlCommand cmd = CreateCommand("select [id], [Username], [Password], [Email] " +
						"from accountTbl where id = @id", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						AccountDTO found = new AccountDTO();
						found.Id = Convert.ToInt32(dr["id"]);
						found.Username = Convert.ToString(dr["Username"]);
						found.Password = Convert.ToString(dr["Password"]);
						found.Email = Convert.ToString(dr["Email"]);
						return found;
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public AccountDTO GetAccountByUsername(string username)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@username", username) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select [id], [Username], [Password], [Email] " +
						"from accountTbl where Username = @username", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							AccountDTO found = new AccountDTO();
							found.Id = Convert.ToInt32(dr["id"]);
							found.Username = Convert.ToString(dr["Username"]);
							found.Password = Convert.ToString(dr["Password"]);
							found.Email = Convert.ToString(dr["Email"]);
							return found;
						}
						else { throw new Exception("Account with username " + username + " could not be found."); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
	}
}
