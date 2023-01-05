using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhTests.FakeDAL
{
	public class FakeCategoryDAL : ICategoryDAL
	{
		private List<CategoryDTO> _categories;
		public FakeCategoryDAL()
		{
			_categories = new List<CategoryDTO>();
		}

		public bool CreateCategory(string name, int? parentCategoryId)
		{
			CategoryDTO category = new CategoryDTO
			{
				Id = new Random().Next(100, 10000),
				Name = name,
				ParentCategoryId = parentCategoryId
			};
			_categories.Add(category);
			return true;
		}

		public CategoryDTO FindCategory(int id)
		{
			foreach(CategoryDTO category in _categories)
			{
				if(category.Id == id) return category;
			}
			return null;
		}

		public CategoryDTO FindParentCategory(int categoryid)
		{
			throw new NotImplementedException();
		}

		public List<CategoryDTO> GetAllCategories()
		{
			throw new NotImplementedException();
		}
		public bool CategoryNameCheck(string categoryname)
		{
			foreach(var ctg in _categories)
			{
				if (string.Equals(categoryname, ctg.Name))
				{
					return true;
				}
			}
			return false;
		}

		public DataTable GetCategoryDataTable(string search)
		{
			throw new NotImplementedException();
		}

		public CategoryDTO GetCategoryFromItem(int itemid)
		{
			throw new NotImplementedException();
		}

		public bool UpdateCategory(int id, string categoryname, int? parentcategoryid)
		{
			throw new NotImplementedException();
		}
	}
}
