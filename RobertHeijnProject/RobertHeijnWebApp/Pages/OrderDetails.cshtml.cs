using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RhClassLibrary.Interfaces;

namespace RobertHeijnWebApp.Pages
{
    [Authorize]
    public class OrderDetailsModel : PageModel
    {
        public readonly IOrderManager orderManager;
        public IItemManager ItemManager { get; set; }
		public int OrderId { get; set; }
		public Dictionary<int, int> OrderItems { get; set; }
        public OrderDetailsModel(IOrderManager orderManager, IItemManager itemManager) 
        { 
            this.orderManager = orderManager;
            this.ItemManager = itemManager;
        }
        public void OnGet(int id)
        {
            this.OrderId = id;
            this.OrderItems = orderManager.GetItemsFromOrder(OrderId);

            int i = 0;
        }
    }
}
