using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;

namespace RobertHeijnWebApp.Pages
{
    public class ItemModel : PageModel
    {
        private readonly IItemManager itemManager;
        private readonly ICategoryManager categoryManager;
        public ItemModel(IItemManager itemManager, ICategoryManager categoryManager)
        {
            this.itemManager = itemManager;
            this.categoryManager = categoryManager;
		}
		[BindProperty]
		public int Id { get; set; }
		[BindProperty]
		public Item Item { get; set; }
        [BindProperty]
        public int Quantity { get; set; }
		[BindProperty]
		public Category Category { get; set; }
        [BindProperty]
        public Unit Unit { get; set; }
        public void OnGet(int id)
        {
            this.Id = id;
			this.Item = itemManager.FindItem(Id);
            this.Unit = Item.Unit;
			this.Category = categoryManager.GetCategoryFromItem(Item);
        }
        public async Task<IActionResult> OnPost(int id)
		{
			Item current = itemManager.FindItem(id);
			JsonSerializerSettings settings = new JsonSerializerSettings();
			settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			Dictionary<int, int> shoppingcart;
				if (Request.Cookies.ContainsKey("shoppingcart"))
				{
					string jsonGetShoppingCart = Request.Cookies["shoppingcart"];
					shoppingcart = JsonConvert.DeserializeObject<Dictionary<int, int>>(jsonGetShoppingCart, settings);
				}
				else { shoppingcart = new Dictionary<int, int>(); }
				if (shoppingcart.ContainsKey(id))
				{
					shoppingcart[id] += Quantity;
				}
				else
				{
					shoppingcart.Add(id, Quantity);
				}
			string jsonPostShoppingCart = JsonConvert.SerializeObject(shoppingcart);
			Response.Cookies.Append("shoppingcart", jsonPostShoppingCart);
			TempData["SuccessMsg"] = "Item was successfully added to cart";
			return RedirectToPage("Item", new { id = Id });

			//}
   //         catch (Exception ex) 
   //         {
   //             Response.WriteAsync(ex.Message);
   //             return ;
   //         }
            //var cookie = HttpContext.Request.Cookies["shopping_cart"];
            //var cart = new List<Item>();
            //if (!string.IsNullOrEmpty(cookie))
            //{
            //	cart = cookie.Split(',').ToList();
            //}

            //// Add the new item to the shopping cart
            //cart.Add(Item);

            //// Save the updated shopping cart to the cookie
            //HttpContext.Response.Cookies.Append("shopping_cart", string.Join(",", cart));
            //Response.WriteAsync(amount.ToString());
		}
    }
}
