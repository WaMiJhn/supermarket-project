using RhClassLibrary.Classes;
using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Interfaces
{
	public interface IItemManager
	{
		public bool CreateItem(string name, decimal price, string imagesource, Unit unit, Category category);
		public List<Item> GetAllItems();
		public Item FindItem(int id);
		public DataTable GetItemDataTable(string search);
		public bool UpdateItem(int id, string name, decimal price, string imagesource, Unit unit, Category category, bool available);
	}
}
