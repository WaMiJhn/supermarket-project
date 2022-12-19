using RhClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Interfaces
{
	public interface IUnitManager
	{
		public bool CreateUnit(string name);
		public List<Unit> GetAllUnits();
		public Unit FindUnit(int id);
		public Unit GetUnitFromItem(Item item);
		public DataTable GetUnitDataTable(string search);
		public bool UpdateUnit(Unit unit, string name);
	}
}
