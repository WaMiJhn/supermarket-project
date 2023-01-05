using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Managers
{
	public class CategoryManager : ICategoryManager
	{
		private readonly ICategoryDAL categoryDAL;
		public CategoryManager(ICategoryDAL categoryDAL)
		{
			this.categoryDAL = categoryDAL;
		}
		public bool CreateCategory(string name, Category? parentCategory)
		{
			try
			{
				if(categoryDAL.CategoryNameCheck(name))
				{
					throw new Exception("Category with name " + name + " already exists, please choose a different one.");
				}
				if (parentCategory == null)
				{
					if (categoryDAL.CreateCategory(name, null))
					{
						return true;
					}
					else { return false; }
				}
				if (categoryDAL.CreateCategory(name, parentCategory.Id))
				{
					return true;
				}
				else { return false; }
			}
			catch (Exception ex) { throw; }
		}
		public List<Category> GetAllCategories()
		{
			try
			{
				List<Category> categories = new List<Category>();
				foreach (var category in categoryDAL.GetAllCategories())
				{
					categories.Add(new Category(category));
				}
				return categories;
			}
			catch (Exception ex) { throw; }
		}
		public Category GetCategoryFromItem(Item item)
		{
			return new Category(categoryDAL.GetCategoryFromItem(item.Id));
		}
		public Category FindCategory(int id)
		{
			try
			{
				return new Category(categoryDAL.FindCategory(id));
			}
			catch (Exception ex) { throw; }
		}
		public Category? FindParentCategory(Category category)
		{
			try
			{
				if (categoryDAL.FindParentCategory(category.Id) == null)
				{
					return null;
				}
				else { return new Category(categoryDAL.FindParentCategory(category.Id)); }
			}
			catch (Exception ex) { throw; }
		}
		public DataTable GetCategoryDataTable(string search)
		{
			try
			{
				return categoryDAL.GetCategoryDataTable(search);
			}
			catch (Exception ex) { throw; }
		}
		public bool UpdateCategory(Category category, string categoryname, Category parentCategory)
		{
			try
			{
				if (parentCategory == null)
				{
					return categoryDAL.UpdateCategory(category.Id, categoryname, null);
				}
				return categoryDAL.UpdateCategory(category.Id, categoryname, parentCategory.Id);
			}
			catch (Exception ex) { throw; }
		}
	}
}
