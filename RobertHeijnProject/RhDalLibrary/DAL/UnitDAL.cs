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
	public class UnitDAL : BaseDAL, IUnitDAL
	{
		//create
		public bool CreateUnit(string name)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@name", name) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("insert into unitTbl (UnitName) " +
						"values (@name)" , sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { return false; }
			}
			catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}

		//read
		public List<UnitDTO> GetAllUnits()
		{
			try
			{
				List<UnitDTO> units = new List<UnitDTO>();
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select [id], [UnitName] " +
						"from unitTbl");
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							UnitDTO unit = new UnitDTO();
							unit.Id = Convert.ToInt32(dr["id"]);
							unit.Name = Convert.ToString(dr["UnitName"]);
							units.Add(unit);
						}
					}
					return units;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
		public UnitDTO FindUnit(int id)
		{
			try
			{
				UnitDTO found = null;
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", id) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select [id], [UnitName] from " +
						"unitTbl where id = @id", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							found = new UnitDTO();
							found.Id = Convert.ToInt32(dr["id"]);
							found.Name = Convert.ToString(dr["UnitName"]);
							return found;
						}
						else { throw new Exception("Unit could not be found"); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
		public UnitDTO GetUnitFromItem(int itemid)
		{
			try
			{
				UnitDTO unit = null;
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@itemid", itemid) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select u.id, u.UnitName from " +
						"unitTbl as u inner join itemTbl as i on u.id = i.UnitId " +
						"where i.id = @itemid", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							unit = new UnitDTO();
							unit.Id = Convert.ToInt32(dr["id"]);
							unit.Name = Convert.ToString(dr["UnitName"]);
							return unit;
						}
						else { throw new Exception("No unit found found"); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
		public DataTable GetUnitDataTable(string search)
		{
			try
			{
				DataTable dt = new DataTable();
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select [id], [UnitName] from unitTbl " +
						"where id like '%" + search + "%' or UnitName like '%" + search + "%'");
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
		public bool UpdateUnit(int id, string name)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", id),
					new SqlParameter("@unitname", name) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("update unitTbl set UnitName = @unitname " +
						"where id = @id", sp);
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
