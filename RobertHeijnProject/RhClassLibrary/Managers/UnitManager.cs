using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Managers
{
	public class UnitManager : IUnitManager
	{
		private readonly IUnitDAL unitDAL;
		public UnitManager(IUnitDAL unitDAL)
		{
			this.unitDAL = unitDAL;
		}
		public bool CreateUnit(string name)
		{
			try
			{
				if (unitDAL.CreateUnit(name))
				{
					return true;
				}
				else { return false; }
			}
			catch (Exception ex) { throw new Exception("Couldn't create a unit."); }
		}
		public List<Unit> GetAllUnits()
		{
			try
			{
				List<Unit> units = new List<Unit>();
				foreach(var unit in unitDAL.GetAllUnits())
				{
					units.Add(new Unit(unit));
				}
				return units;
			}
			catch (Exception ex) { throw new Exception("Couldn't load all units"); }
		}
		public Unit FindUnit(int id)
		{
			try
			{
				return new Unit(unitDAL.FindUnit(id));
			}
			catch(Exception ex) { throw new Exception("Couldn't find unit."); }
		}
		public Unit GetUnitFromItem(Item item)
		{
			try
			{
				return new Unit(unitDAL.GetUnitFromItem(item.Id));
			}
			catch(Exception ex) { throw new Exception(ex.Message); }
		}
		public DataTable GetUnitDataTable(string search)
		{
			try
			{
				return unitDAL.GetUnitDataTable(search);
			}
			catch (Exception ex) { throw new Exception(ex.Message); }
		}
		public bool UpdateUnit(Unit unit, string name)
		{
			try
			{
				return unitDAL.UpdateUnit(unit.Id, name);
			}
			catch (Exception ex) { throw new Exception(ex.Message); }
		}
	}
}
