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
    public class PersonDAL : BaseDAL, IPersonDAL
	{
		//create
		public int CreateCustomer(string firstname, string lastname, int accountid)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@firstname", firstname),
					new SqlParameter("@lastname", lastname),
					new SqlParameter("@accountid", accountid) };
				if (OpenConnection())
				{
					SqlCommand cmdPersonTbl = CreateCommand("insert into personTbl (FirstName, LastName, AccountId) " +
						"values (@firstname, @lastname, @accountid); SELECT SCOPE_IDENTITY()", sp);
					int personid = Convert.ToInt32(cmdPersonTbl.ExecuteScalar());
					SqlCommand cmdCustomerTbl = CreateCommand("insert into customerTbl (CustomerId) " +
						"values ("+ personid + ")", sp);
					cmdCustomerTbl.ExecuteNonQuery();
					return personid;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch(Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public int CreateEmployee(string firstname, string lastname, int accountid, decimal wage)
		{
			try
			{
                SqlParameter[] sp = new SqlParameter[] {
                    new SqlParameter("@firstname", firstname),
                    new SqlParameter("@lastname", lastname),
                    new SqlParameter("@accountid", accountid),
					new SqlParameter("@wage", wage) };
				if (OpenConnection())
				{
					SqlCommand cmdPersonTbl = CreateCommand("insert into personTbl (FirstName, LastName, AccountId) " +
                        "values (@firstname, @lastname, @accountid); SELECT SCOPE_IDENTITY()", sp);
					int personid = Convert.ToInt32(cmdPersonTbl.ExecuteScalar());
					SqlCommand cmdEmployeeTbl = CreateCommand("insert into employeeTbl (EmployeeId, Wage) " +
						"values (" +personid+ ", @wage)", sp);
					cmdEmployeeTbl.ExecuteNonQuery();
					return personid;
                }
                else { throw new Exception("Database connection could not be opened."); }
            }
			catch(Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public bool CreateAddress(string street, string housenumber, string zipcode, int personid)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@street", street),
					new SqlParameter("@housenumber", housenumber),
					new SqlParameter("@zipcode", zipcode),
					new SqlParameter("@personid", personid) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("insert into addressTbl (Street, HouseNumber, Zipcode, PersonId) " +
						"values (@street, @housenumber, @zipcode, @personid)", sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch(Exception ex) { throw; }
			finally { CloseConnection(); }
		}

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
						"inner join accountTbl as ac on ac.id = p.AccountId " +
						"where p.id = @id", sp);
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
        public DataTable GetEmployeeDataTable(string search)
        {
            try
            {
                DataTable dt = new DataTable();
                if (OpenConnection())
                {
                    SqlCommand cmd = CreateCommand("select p.id, p.FirstName, p.LastName, e.Wage, a.Username, a.Email " +
                        "from personTbl as p inner join employeeTbl as e on p.id = e.EmployeeId " +
                        "inner join accountTbl as a on p.AccountId = a.id " +
                        "where p.id like '%" + search + "%' or p.FirstName like '%" + search + "%' or p.LastName like '%" + search + "%' " +
                        "or a.Username like '%" + search + "%' or a.Email like '%" + search + "%'");
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    return dt;
                }
                else { throw new Exception("Database connection could not be opened."); }
            }
            catch (Exception ex) { throw; }
            finally { CloseConnection(); }
        }
        //update
        public bool UpdatePerson(int personid, string firstname, string lastname)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@personid", personid),
					new SqlParameter("@firstname", firstname),
					new SqlParameter("@lastname", lastname) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("update personTbl set " +
						"FirstName = @firstname, LastName = @lastname " +
						"where id = @personid", sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public bool UpdateAddress(int personid, string street, string housenumber, string zipcode)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@personid", personid),
					new SqlParameter("@street", street),
					new SqlParameter("@housenumber", housenumber),
					new SqlParameter("@zipcode", zipcode) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("update addressTbl set " +
						"Street = @street, HouseNumber = @housenumber, Zipcode = @zipcode " +
						"where PersonId = @personid", sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
	}
}
