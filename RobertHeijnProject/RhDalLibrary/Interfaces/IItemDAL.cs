using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.Interfaces
{
	public interface IItemDAL
	{
		public bool CreateItem(string name, decimal price, string imagesource, int unitId, int categoryId);
		public List<ItemDTO> GetAllItems();
		public ItemDTO FindItem(int id);
		public DataTable GetItemDataTable(string search);
		public bool UpdateItem(int itemid, string name, decimal price, string imagesource, int unitId, int categoryId, bool available);
	}
}
