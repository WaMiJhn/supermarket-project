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
	public class TestOrderManager
	{
		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void TestCreatingMoreThanFiveHomeDeliveriesForTheSameTimeSlot()
		{
			//it shouldn't be possible to create more than five homedeliveries for the same time slot
			IOrderManager orderManager = new OrderManager(new FakeOrderDAL());
			for(int i = 0; i < 6; i++)
			{
				orderManager.CreateHomeDelivery(new DateTime(2022, 12, 23, 12, 0, 0));
			}
		}
		[TestMethod]
		public void TestCreateExactlyFiveHomeDeliveriesForTheSameTimeSlot()
		{
			IOrderManager orderManager = new OrderManager(new FakeOrderDAL());
			for (int i = 0; i < 5; i++)
			{
				orderManager.CreateHomeDelivery(new DateTime(2022, 12, 23, 12, 0, 0));
			}
		}
		[TestMethod]
		public void TestCreateLessThanFiveHomeDeliveriesForTheSameTimeSlot()
		{
			IOrderManager orderManager = new OrderManager(new FakeOrderDAL());
			for (int i = 0; i < 3; i++)
			{
				orderManager.CreateHomeDelivery(new DateTime(2022, 12, 23, 12, 0, 0));
			}
		}
		[TestMethod]
		public void TestCreateAnyAmountPickupDeliveriesForTheSameTimeSlot()
		{
			//since it shouldn't matter how many pick up delivery orders there are made for the same timeslot
			IOrderManager orderManager = new OrderManager(new FakeOrderDAL());
			for (int i = 0; i < new Random().Next(50, 100); i++)
			{
				orderManager.CreatePickupDelivery("LOCATION" ,new DateTime(2022, 12, 23, 12, 0, 0));
			}
		}
	}
}
