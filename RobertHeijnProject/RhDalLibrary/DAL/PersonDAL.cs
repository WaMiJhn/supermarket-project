using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DAL
{
	public class PersonDAL : BaseDAL, IPersonDAL
	{
		//create

		//read
		public CustomerDTO GetCustomerById(int id)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", id) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select p.id as personid, p.FirstName, p.LastName, ad.id as addressid, ad.Street, ad.HouseNumber, ad.Zipcode, ac.id as accountid, " +
						"ac.Username, ac.Password, ac.Email from personTbl as p " +
						"inner join customerTbl as c on c.CustomerId = p.id " +
						"inner join addressTbl as ad on ad.PersonId = p.id " +
						"inner join accountTbl as ac on ac.id = p.AccountId", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							AddressDTO address = new AddressDTO { 
								Id = Convert.ToInt32(dr["addressid"]),
								Street = Convert.ToString(dr["Street"]),
								HouseNumber = Convert.ToString(dr["HouseNumber"]),
								ZipCode = Convert.ToString(dr["Zipcode"]) };
							AccountDTO account = new AccountDTO { 
								Id = Convert.ToInt32(dr["accountid"]),
								Username = Convert.ToString(dr["Username"]),
								Password = Convert.ToString(dr["Password"]),
								Email = Convert.ToString(dr["Email"]) };
							CustomerDTO customer = new CustomerDTO { 
								Id = Convert.ToInt32(dr["personid"]),
								FirstName = Convert.ToString(dr["FirstName"]),
								LastName = Convert.ToString(dr["LastName"]),
								Address = address,
								Account = account };
							return customer;
						}
						else { throw new Exception("Customer with id " + id + " could not be found."); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
	}
}
