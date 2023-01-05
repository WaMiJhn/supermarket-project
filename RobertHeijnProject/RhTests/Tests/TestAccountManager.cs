using RhClassLibrary.Classes;
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
    public class TestAccountManager
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateAccountWithUsernameThatAlreadyExists()
        {
            IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
            //there is already an account with username: test1 made in the constructor of FakeAccountDAL
            int accountid = accountManager.CreateAccount("test1", "123", "email100");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateAccountWithEmailThatAlreadyExists()
        {
			IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
			//there is already an account with email: test1@mail.com made in the constructor of FakeAccountDAL
			int accountid = accountManager.CreateAccount("test100", "123", "test1@mail.com");
		}
		[TestMethod]
		public void TestCreateAccountWithDistinctUsernamesAndEmails()
		{
			IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
			int accountid1 = accountManager.CreateAccount("test500", "123", "email100");
			int accountid2 = accountManager.CreateAccount("differentusername", "123", "email200");
			Assert.AreNotEqual(accountManager.GetAccountById(accountid1), accountManager.GetAccountById(accountid2));
		}
		[TestMethod]
        public void TestCreateAccount()
        {
            IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
            int accountid = accountManager.CreateAccount("test100", "123", "email100");
            if (accountid < 0)
            {
                throw new Exception("accountid can't be smaller than 0");
            }
            Assert.AreEqual(typeof(int), accountid.GetType());
        }
        [TestMethod]
        public void TestLoginValidationCustomerHashedPassword()
        {
            IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
            int accountid = accountManager.CreateAccount("test100", "123", "email100");
            bool validation = accountManager.LoginValidationCustomer("test100", "123");
            Assert.IsTrue(validation);
        }
        [TestMethod]
        public void TestLoginValidationMultipleCustomersWithSamePassword()
        {
			IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
			int accountid = accountManager.CreateAccount("test100", "123", "email100");
			bool validation = accountManager.LoginValidationCustomer("test100", "123");
			Assert.IsTrue(validation);

			int accountid2 = accountManager.CreateAccount("test101", "123", "email200");
			bool validation2 = accountManager.LoginValidationCustomer("test101", "123");
			Assert.IsTrue(validation2);

			int accountid3 = accountManager.CreateAccount("test102", "123", "email300");
			bool validation3 = accountManager.LoginValidationCustomer("test102", "123");
			Assert.IsTrue(validation3);

			int accountid4 = accountManager.CreateAccount("test103", "123", "email400");
			bool validation4 = accountManager.LoginValidationCustomer("test103", "123");
			Assert.IsTrue(validation4);
		}
        [TestMethod]
        public void TestLoginWrongPasswordRightUsernameCustomers()
        {
			IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
			int accountid = accountManager.CreateAccount("test100", "123", "email100");
			bool validation = accountManager.LoginValidationCustomer("test100", "12");
			Assert.IsFalse(validation);
		}
        [TestMethod]
        public void TestLoginWrongUsernameRightPasswordCustomers()
        {
			IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
			int accountid = accountManager.CreateAccount("test100", "123", "email100");
			bool validation = accountManager.LoginValidationCustomer("differentusername", "123");
			Assert.IsFalse(validation);
		}

        [TestMethod]
        public void TestLoginValidationEmployeeHashedPassword()
        {
            IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
            int accountid = accountManager.CreateAccount("test200", "123", "email100");
            bool validation = accountManager.LoginValidationEmployee("test200", "123");
            Assert.IsTrue(validation);
        }
        [TestMethod]
        public void TestFindAccountById()
        {
            IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
            int accountid = accountManager.CreateAccount("test200", "123", "email100");
            var account = accountManager.GetAccountById(accountid);
            Assert.AreEqual(account.Id, accountid);
            Assert.AreEqual(account.Username, "test200");
        }
        [TestMethod]
        public void TestPasswordGetsSavedAsHashedPassword()
        {
            IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
            int accountid = accountManager.CreateAccount("test200", "123", "email");
            var account = accountManager.GetAccountById(accountid);
            Assert.AreNotEqual(account.Password, "123");
        }
        [TestMethod]
        public void TestHashedPasswordsAreAllDistinct()
        {
			//because a password gets salted, every hashed password should be unique
			IAccountManager accountManager = new AccountManager(new FakeAccountDAL());
            string samepassword = "123";
			int accountid1 = accountManager.CreateAccount("test100", samepassword, "email100");
			var account1 = accountManager.GetAccountById(accountid1);

			int accountid2 = accountManager.CreateAccount("test200", samepassword, "email200");
			var account2 = accountManager.GetAccountById(accountid2);
            Assert.AreNotEqual(account1.Password, account2.Password);
		}
    }
}
