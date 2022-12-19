using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using RhDalLibrary.DAL;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Managers
{
    public class ItemManager : IItemManager
    {
        private readonly IItemDAL itemDAL;
        public ItemManager(IItemDAL itemDAL)
        {
            this.itemDAL = itemDAL;
        }
		public bool CreateItem(string name, decimal price, string imagesource, Unit unit, Category category)
        {
            try
            {
                if(itemDAL.CreateItem(name, price, imagesource, unit.Id, category.Id))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { throw; }
        }
		public List<Item> GetAllItems()
        {
            try
            {
                List<Item> items = new List<Item>();
                foreach (var item in itemDAL.GetAllItems())
                {
                    items.Add(new Item(item));
                }
                return items;
            }
            catch (Exception ex) { throw; }
        }
        public Item FindItem(int id)
        {
            try
            {
                return new Item(itemDAL.FindItem(id));
            }
            catch (Exception ex) { throw; }
        }
		public DataTable GetItemDataTable(string search)
        {
			try
			{
				return itemDAL.GetItemDataTable(search);
			}
			catch (Exception ex) { throw; }
		}
		public bool UpdateItem(int itemid, string name, decimal price, string imagesource, Unit unit, Category category, bool available)
        {
            try
            {
                if (itemDAL.UpdateItem(itemid, name, price, imagesource, unit.Id, category.Id, available))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
