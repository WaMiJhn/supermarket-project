using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.Interfaces
{
	public interface ICategoryDAL
	{
		public bool CreateCategory(string name, int? parentCategoryId);
		public List<CategoryDTO> GetAllCategories();
		public CategoryDTO GetCategoryFromItem(int itemid);
		public CategoryDTO FindCategory(int id);
		public CategoryDTO FindParentCategory(int categoryid);
		public bool CategoryNameCheck(string categoryname);
		public DataTable GetCategoryDataTable(string search);
		public bool UpdateCategory(int id, string categoryname, int? parentcategoryid);
	}
}
