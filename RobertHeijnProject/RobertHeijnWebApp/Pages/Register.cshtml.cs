using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RhClassLibrary.Interfaces;

namespace RobertHeijnWebApp.Pages
{
    public class RegisterModel : PageModel
    {
		private readonly IAccountManager accountManager;
		private readonly ICustomerManager customerManager;
        [BindProperty]
        public string FirstName { get; set; }
		[BindProperty]
		public string LastName { get; set; }
		[BindProperty]
		public string Street { get; set; }
		[BindProperty]
		public string HouseNumber { get; set; }
		[BindProperty]
		public string Zipcode { get; set; }
		[BindProperty]
		public string Username { get; set; }
		[BindProperty]
		public string Email { get; set; }
		[BindProperty]
		public string Password { get; set; }
		public RegisterModel(IAccountManager accountManager, ICustomerManager customerManager)
        {
			this.accountManager = accountManager;
			this.customerManager = customerManager;
        }
		public async Task OnPost()
		{
			try
			{
				int accountid = accountManager.CreateAccount(Username, Password, Email);
				int customerid = customerManager.CreateCustomer(this.FirstName, this.LastName, accountid);
				customerManager.CreateAddress(Street, HouseNumber, Zipcode, customerid);

				TempData["Registration"] = "Registration was successful.";
				Response.Redirect("/Index");
			}
			catch (Exception ex)
			{
				Response.WriteAsync(ex.Message);
			}
		}
	}
}
