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
	public class ItemDAL : BaseDAL, IItemDAL
	{
		//create
		public bool CreateItem(string name, decimal price, string imagesource, int unitId, int categoryId)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@name", name),
					new SqlParameter("@price", price),
					new SqlParameter("@imagesource", imagesource),
					new SqlParameter("@unitId", unitId),
					new SqlParameter("@categoryId", categoryId),
					new SqlParameter("@available", false) };
				
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("insert into itemTbl (ItemName, Price, ImageSource, UnitId, CategoryId, Available) " +
						"values (@name, @price, @imagesource, @unitId, @categoryId, @available)", sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { return false; }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		//read
		public List<ItemDTO> GetAllItems()
		{
			try
			{
				List<ItemDTO> items = new List<ItemDTO>();
				if(OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select i.id, i.ItemName, i.Price, i.ImageSource, i.UnitId, u.UnitName, i.CategoryId, i.Available " +
						"from itemTbl as i inner join unitTbl as u on i.UnitId = u.id");
					SqlDataReader dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						ItemDTO item = new ItemDTO();
						item.ID = Convert.ToInt32(dr["id"]);
						item.Name = Convert.ToString(dr["ItemName"]);
						item.Price = Convert.ToDecimal(dr["Price"]);
						item.ImageSource = Convert.ToString(dr["ImageSource"]);
						item.Unit = new UnitDTO { Id = Convert.ToInt32(dr["UnitId"]), Name = Convert.ToString(dr["UnitName"])};
						item.CategoryId = Convert.ToInt32(dr["CategoryId"]);
						item.Available = Convert.ToBoolean(dr["Available"]);
						items.Add(item);
					}
					return items;
				}
				else
				{
					throw new Exception("Database connection could not be opened.");
				}
			}
			catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
		public ItemDTO FindItem(int id)
		{
			try
			{
				ItemDTO found = null;
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", id) };
				if(OpenConnection()) 
				{
					SqlCommand cmd = CreateCommand("select i.id, i.ItemName, i.Price, i.ImageSource, i.UnitId, u.UnitName, i.CategoryId, i.Available " +
						"from itemTbl as i inner join unitTbl as u on i.UnitId = u.id where i.id = @id", sp);
					SqlDataReader dr = cmd.ExecuteReader();
					if(dr.Read())
					{
						found = new ItemDTO();
						found.ID = Convert.ToInt32(dr["id"]);
						found.Name = Convert.ToString(dr["ItemName"]);
						found.Price = Convert.ToDecimal(dr["Price"]);
						found.ImageSource = Convert.ToString(dr["ImageSource"]);
						found.Unit = new UnitDTO { Id = Convert.ToInt32(dr["UnitId"]), Name = Convert.ToString(dr["UnitName"]) };
						found.CategoryId = Convert.ToInt32(dr["CategoryId"]);
						found.Available = Convert.ToBoolean(dr["Available"]);
						return found;
					}
					else { throw new Exception("Item with id " + id +  " could not be found."); }
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (SqlException ex) { throw; }
			finally { CloseConnection(); }
		}
		public DataTable GetItemDataTable(string search)
		{
			try
			{
				DataTable dt = new DataTable();
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select i.id, i.ItemName, i.Price, u.UnitName, c.CategoryName " +
						"from itemTbl as i inner join categoryTbl as c on i.CategoryId = c.id " +
						"inner join unitTbl as u on u.id = i.UnitId " +
						"where i.id like '%" + search + "%' or i.ItemName like '%" + search + "%' or c.CategoryName like '%" + search + "%'");
					SqlDataAdapter adp = new SqlDataAdapter(cmd);
					adp.Fill(dt);
					return dt;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
		//update
		public bool UpdateItem(int id, string name, decimal price, string imagesource, int unitId, int categoryId, bool available)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", id),
					new SqlParameter("@name", name),
					new SqlParameter("@price", price),
					new SqlParameter("@imagesource", imagesource),
					new SqlParameter("@unitId", unitId),
					new SqlParameter("@categoryId", categoryId),
					new SqlParameter("@available", available) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("update itemTbl set ItemName = @name, Price = @price, ImageSource = @imagesource, UnitId = @unitId, " +
						"CategoryId = @categoryId, Available = @available where id = @id", sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { return false; }
			}
			catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
	}
}
