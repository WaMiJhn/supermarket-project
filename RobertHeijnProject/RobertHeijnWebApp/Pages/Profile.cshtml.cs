using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace RobertHeijnWebApp.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly ICustomerManager customerManager;
        private readonly IAccountManager accountManager;
        private int id;
        public Customer LoggedIn { get; set; }
        public ProfileModel(ICustomerManager customerManager, IAccountManager accountManager)
        {
            this.customerManager = customerManager;
            this.accountManager = accountManager;
        }
        [BindProperty]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [BindProperty]
		[Required]
		public string LastName { get; set; }
        [BindProperty]
		[Required]
		public string Street { get; set; }
		[BindProperty]
		[Required]
		public string HouseNumber { get; set; }
		[BindProperty]
		[Required]
		public string Zipcode { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Email { get; set; }
		public void OnGet()
        {
            this.id = Convert.ToInt32(User.FindFirst("id").Value);
            this.LoggedIn = customerManager.GetCustomerById(id);
		}
        public async Task<IActionResult> OnPostSave()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                int customerid = Convert.ToInt32(User.FindFirst("id").Value);

				if (customerManager.UpdateCustomer(customerid, FirstName, LastName, Street, HouseNumber, Zipcode) && accountManager.UpdateAccount(customerManager.GetCustomerById(customerid).Account, Username, Email))
                {
					return RedirectToPage("/Profile", id = Convert.ToInt32(User.FindFirst("id").Value));
				}
                else { throw new Exception("Couldn't update information."); }
            }
            catch (Exception ex)
            {
				return new RedirectToPageResult("/Profile", id = Convert.ToInt32(User.FindFirst("id").Value));
			}
        }
    }
}
