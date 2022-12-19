using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;

namespace RobertHeijnWebApp.Pages
{
    public class ShopModel : PageModel
    {
        private readonly IItemManager itemManager;
        public ShopModel(IItemManager itemManager)
        {
            this.itemManager = itemManager;
        }
        public List<Item> Items { get; set; }
        public void OnGet()
        {
            Items = itemManager.GetAllItems();
        }
    }
}
