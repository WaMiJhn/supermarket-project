using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.Interfaces
{
	public interface IUnitDAL
	{
		public bool CreateUnit(string name);
		public List<UnitDTO> GetAllUnits();
		public UnitDTO FindUnit(int id);
		public UnitDTO GetUnitFromItem(int itemid);
		public DataTable GetUnitDataTable(string search);
		public bool UpdateUnit(int id, string name);
	}
}
