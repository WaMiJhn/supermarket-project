using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DAL
{
	public class CategoryDAL : BaseDAL, ICategoryDAL
	{
		//create
		public bool CreateCategory(string name, int? parentCategoryId)
		{
			try
			{
				List<SqlParameter> spList = new List<SqlParameter> {
					new SqlParameter("@name", name) };
				if (parentCategoryId == null) { spList.Add(new SqlParameter("@parentcategoryid", DBNull.Value)); }
				else { spList.Add(new SqlParameter("@parentcategoryid", parentCategoryId)); }
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("insert into categoryTbl (CategoryName, ParentCategoryId) " +
						"values (@name, @parentcategoryid)", spList.ToArray());
					cmd.ExecuteNonQuery();
					return true;
				}
				else { return false; }
			}
			catch (SqlException ex) { throw; }
			finally { CloseConnection(); }
		}
		//read
		public List<CategoryDTO> GetAllCategories()
		{
			try
			{
				List<CategoryDTO> categories = new List<CategoryDTO>();
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select [id], [CategoryName], [ParentCategoryId] from categoryTbl");
					SqlDataReader dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						CategoryDTO category = new CategoryDTO();
						category.Id = Convert.ToInt32(dr["id"]);
						category.Name = Convert.ToString(dr["CategoryName"]);
						if (dr["ParentCategoryId"] != DBNull.Value)
						{
							category.ParentCategoryId = Convert.ToInt32(dr["ParentCategoryId"]);
						}
						categories.Add(category);
					}
					return categories;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (SqlException ex) { throw; }
			finally { CloseConnection(); }
		}
		public CategoryDTO GetCategoryFromItem(int itemid)
		{
			try
			{
				CategoryDTO category = null;
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@itemid",itemid) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select c.id, c.CategoryName, c.ParentCategoryId " +
						"from categoryTbl as c inner join itemTbl as i on c.id = i.CategoryId " +
						"where i.id = @itemid", sp);
					SqlDataReader dr = cmd.ExecuteReader();
					if (dr.Read())
					{
						category = new CategoryDTO();
						category.Id = Convert.ToInt32(dr["id"]);
						category.Name = Convert.ToString(dr["CategoryName"]);
						if (dr["ParentCategoryId"] != DBNull.Value)
						{
							category.ParentCategoryId = Convert.ToInt32(dr["ParentCategoryId"]);
						}
						return category;
					}
					else { throw new Exception("Item with id " + itemid + " could not be found."); }
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			//catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
		public CategoryDTO FindCategory(int id)
		{
			try
			{
				CategoryDTO found = null;
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", id) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select [id], [CategoryName], [ParentCategoryId] " +
						"from categoryTbl where id = @id", sp);
					using(SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							found = new CategoryDTO();
							found.Id= Convert.ToInt32(dr["id"]);
							found.Name = Convert.ToString(dr["CategoryName"]);
							if (dr["ParentCategoryId"] != DBNull.Value)
							{
								found.ParentCategoryId = Convert.ToInt32(dr["ParentCategoryId"]);
							}
							return found;
						}
						else { throw new Exception("Category could not be found."); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
		public CategoryDTO FindParentCategory(int categoryid)
		{
			try
			{
				CategoryDTO found = null;
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", categoryid) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select c2.id, c2.CategoryName, c2.ParentCategoryId " +
						"from categoryTbl as c1 left outer join categoryTbl as c2 on c1.ParentCategoryId = c2.id " +
						"where c1.id = @id", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							if (dr["id"] == DBNull.Value) { return found; }
							found = new CategoryDTO();
							found.Id = Convert.ToInt32(dr["id"]);
							found.Name = Convert.ToString(dr["CategoryName"]);
							if (dr["ParentCategoryId"] != DBNull.Value)
							{
								found.ParentCategoryId = Convert.ToInt32(dr["ParentCategoryId"]);
							}
							return found;
						}
						else { throw new Exception("Parent category could not be found."); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public bool CategoryNameCheck(string categoryname)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@categoryname", categoryname) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select count(*) from categoryTbl " +
						"where CategoryName = @categoryname", sp);
					return (int)cmd.ExecuteScalar() > 0;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch(Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public DataTable GetCategoryDataTable(string search)
		{
			try
			{
				DataTable dt = new DataTable();
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select c1.id, c1.CategoryName, c2.CategoryName as ParentCategory " +
						"from categoryTbl as c1 left outer join categoryTbl as c2 on c1.ParentCategoryId = c2.id " +
						"where c1.id like '%" + search + "%' or c1.CategoryName like '%" + search + "%'");
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
		public bool UpdateCategory(int id, string categoryname, int? parentcategoryid)
		{
			try
			{
				List<SqlParameter> spList = new List<SqlParameter> {
					new SqlParameter("@id", id),
					new SqlParameter("@categoryname", categoryname) };
				if (parentcategoryid == null) { spList.Add(new SqlParameter("@parentcategoryid", DBNull.Value)); }
				else { spList.Add(new SqlParameter("@parentcategoryid", parentcategoryid)); }
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("update categoryTbl set CategoryName = @categoryname, ParentCategoryId = @parentcategoryid " +
						"where id = @id", spList.ToArray());
					cmd.ExecuteNonQuery();
					return true;
				}
				else { return false; }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
	}
}
