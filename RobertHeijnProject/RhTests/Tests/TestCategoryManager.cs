using RhClassLibrary.Interfaces;
using RhClassLibrary.Managers;
using RhTests.FakeDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhTests.Tests
{
	[TestClass]
	public class TestCategoryManager
	{
		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void CreateCategoryWithSameName()
		{
			ICategoryManager categoryManager = new CategoryManager(new FakeCategoryDAL());
			string samename = "category";
			categoryManager.CreateCategory(samename, null);
			categoryManager.CreateCategory(samename, null);
		}
		[TestMethod]
		public void CreateCategoryWithDifferentName()
		{
			ICategoryManager categoryManager = new CategoryManager(new FakeCategoryDAL());
			bool valid1= categoryManager.CreateCategory("Category1", null);
			bool valid2= categoryManager.CreateCategory("Category2", null);
			Assert.IsTrue(valid2&& valid1);
		}
	}
}
