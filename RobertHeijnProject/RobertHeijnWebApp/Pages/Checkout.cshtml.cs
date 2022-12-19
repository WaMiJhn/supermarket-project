using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RhClassLibrary.Interfaces;
using RhClassLibrary.Classes;
using System.Security.Principal;
using System.ComponentModel.DataAnnotations;

namespace RobertHeijnWebApp.Pages
{
    public class CheckoutModel : PageModel
    {
        public IItemManager itemManager { get; set; }
        public ICustomerManager customerManager { get; set; }
        public Dictionary<int, int> ShoppingCart { get; set; }
        public bool ValidShoppingCart { get; set; }
        public Customer loggedIn { get; set; }
		private readonly IOrderManager orderManager;
        public CheckoutModel(IItemManager itemManager, ICustomerManager customerManager, IOrderManager orderManager)
        {
            this.itemManager = itemManager;
            this.customerManager = customerManager;
			this.orderManager = orderManager;
		}
		[BindProperty]
		public string Location { get; set; }

		public async Task OnGet()
        {
			if (User.Identity.IsAuthenticated)
			{
				this.loggedIn = customerManager.GetCustomerById(Convert.ToInt32(User.FindFirst("id").Value));
			}
			if (!Request.Cookies.ContainsKey("shoppingcart"))
			{
				ValidShoppingCart = false;
			}
			else if (Request.Cookies.ContainsKey("shoppingcart"))
			{
				Dictionary<int, int> shoppingcart = JsonConvert.DeserializeObject<Dictionary<int, int>>(Request.Cookies["shoppingcart"]);
				if (shoppingcart.Count > 0)
				{
					ValidShoppingCart = true;
					this.ShoppingCart = shoppingcart;
				}
				else { ValidShoppingCart = false; }
			}
			TempData["Message"] = "Please add an item to your cart before checking out.";
			TempData.Keep();
        }
        public async Task<IActionResult> OnPostCheckOut()
		{
			//try
			//{
				int deliveryoptionid = -1;
				string deliveryoption = Request.Form["DeliveryOption"];
				Dictionary<int, int> shoppingcart = JsonConvert.DeserializeObject<Dictionary<int, int>>(Request.Cookies["shoppingcart"]);
				if (string.Equals(deliveryoption, "pickup"))
				{
					string inputdate = Request.Form["inputDatePickup"];
					string inputtime = Request.Form["inputTimePickup"];
					DateTime preferredTimeSlot = DateTime.Parse(inputdate + ' ' + inputtime);
					deliveryoptionid = orderManager.CreatePickupDelivery(Location, preferredTimeSlot);
				}
				else if (string.Equals(deliveryoption, "home"))
				{
					string inputdate = Request.Form["inputDateHome"];
					string inputtime = Request.Form["inputTimeHome"];
					DateTime deliverDateTime = DateTime.Parse(inputdate + ' ' + inputtime);
					deliveryoptionid = orderManager.CreateHomeDelivery(deliverDateTime);
				}
				if (deliveryoptionid < 0) { throw new Exception("Error with checking out."); }
				if (User.Identity.IsAuthenticated)
				{
					int customerid = Convert.ToInt32(User.FindFirst("id").Value);
					orderManager.CreateOrderWithShoppingCart(shoppingcart, deliveryoptionid, customerid);
				}
				else
				{
					orderManager.CreateOrderWithShoppingCart(shoppingcart, deliveryoptionid, null);
				}
				TempData["CheckOut"] = "Order was successfully placed!";
				Response.Cookies.Delete("shoppingcart");
				return RedirectToPage("/Index");
			//}
			//catch(Exception ex) 
			//{
			//	TempData["Error"] = ex.Message;
			//	return RedirectToPage("/Checkout", ValidShoppingCart = true); 
			//}
        }
    }
}
