using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using NuGet.Configuration;
using RhClassLibrary.Interfaces;

namespace RobertHeijnWebApp.Pages
{
    public class CartModel : PageModel
    {
        public Dictionary<int, int> ShoppingCart { get; set; }
        public IItemManager itemManager { get; set; }
        public CartModel(IItemManager itemManager)
        {
            this.itemManager = itemManager;
        }
        public void OnGet()
        {
            if (Request.Cookies.ContainsKey("shoppingcart"))
            {
				string json = Request.Cookies["shoppingcart"];
                ShoppingCart = JsonConvert.DeserializeObject<Dictionary<int, int>>(json);
			}
        }
        public async Task<IActionResult> OnPostRemoveItem(int id)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            Dictionary<int, int> shoppingcart;
            if (Request.Cookies.ContainsKey("shoppingcart"))
            {
                string jsonGetShoppingCart = Request.Cookies["shoppingcart"];
                shoppingcart = JsonConvert.DeserializeObject<Dictionary<int, int>>(jsonGetShoppingCart, settings);
                if (shoppingcart.ContainsKey(id))
                {
                    shoppingcart.Remove(id);
                    string jsonPostShoppingCart = JsonConvert.SerializeObject(shoppingcart);
                    Response.Cookies.Append("shoppingcart", jsonPostShoppingCart);
                }
            }
            return RedirectToPage("Cart");
        }
        public async Task<IActionResult> OnPostDecrement(int id)
        {
			JsonSerializerSettings settings = new JsonSerializerSettings();
			settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			Dictionary<int, int> shoppingcart;
			if (Request.Cookies.ContainsKey("shoppingcart"))
			{
				string jsonGetShoppingCart = Request.Cookies["shoppingcart"];
				shoppingcart = JsonConvert.DeserializeObject<Dictionary<int, int>>(jsonGetShoppingCart, settings);
				if (shoppingcart.ContainsKey(id))
				{
                    if (shoppingcart[id] - 1 == 0)
                    {
						shoppingcart.Remove(id);
					}
                    else
                    {
						shoppingcart[id] -= 1;
					}
					string jsonPostShoppingCart = JsonConvert.SerializeObject(shoppingcart);
					Response.Cookies.Append("shoppingcart", jsonPostShoppingCart);
				}
			}
			return RedirectToPage("Cart");
        
		}
		public async Task<IActionResult> OnPostIncrement(int id)
		{
			JsonSerializerSettings settings = new JsonSerializerSettings();
			settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			Dictionary<int, int> shoppingcart;
			if (Request.Cookies.ContainsKey("shoppingcart"))
			{
				string jsonGetShoppingCart = Request.Cookies["shoppingcart"];
				shoppingcart = JsonConvert.DeserializeObject<Dictionary<int, int>>(jsonGetShoppingCart, settings);
				if (shoppingcart.ContainsKey(id))
				{
					shoppingcart[id] += 1;
					string jsonPostShoppingCart = JsonConvert.SerializeObject(shoppingcart);
					Response.Cookies.Append("shoppingcart", jsonPostShoppingCart);
				}
			}
			return RedirectToPage("Cart");

		}
		public async Task<IActionResult> OnPostCheckout()
		{
			return RedirectToPage("Checkout");
		}
	}
}
//@{
//	// Get the current quantity from the cookie
//	int quantity = 0;
//	if (Request.Cookies.ContainsKey("quantity"))
//	{
//		int.TryParse(Request.Cookies["quantity"], out quantity);
//	}

//	// Increment or decrement the quantity based on the form submission
//	if (IsPost)
//	{
//		if (Request.Form["increment"] != null)
//		{
//			quantity++;
//		}
//		else if (Request.Form["decrement"] != null)
//		{
//			quantity--;
//		}
//	}

//	// Save the updated quantity in the cookie
//	Response.Cookies.Append("quantity", quantity.ToString());
//}

//< !--Form with submit buttons for incrementing and decrementing the quantity -->
//<form method="post">
//    <!-- Hidden field with the current quantity -->
//    <input type="hidden" name="quantity" value="@quantity" />
//    <button type="submit" name="increment">+</button>
//    <button type="submit" name="decrement">-</button>
//</form>
