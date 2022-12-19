using RhClassLibrary.Classes;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Interfaces
{
	public interface ICategoryManager
	{
		public bool CreateCategory(string name, Category? parentCategory);
		public List<Category> GetAllCategories();
		public Category GetCategoryFromItem(Item item);
		public Category FindCategory(int id);
		public Category? FindParentCategory(Category category);
		public DataTable GetCategoryDataTable(string search);
		public bool UpdateCategory(Category category, string categoryname, Category parentCategory);
	}
}
