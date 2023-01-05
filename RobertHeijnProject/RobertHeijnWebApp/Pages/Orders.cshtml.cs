using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RhClassLibrary.Classes;
using RhClassLibrary.Interfaces;

namespace RobertHeijnWebApp.Pages
{
    [Authorize]
    public class OrdersModel : PageModel
    {
        private readonly IOrderManager orderManager;
        private int customerid;
        public List<Order> Orders { get; set; }
        public OrdersModel(IOrderManager orderManager)
        {
            this.orderManager = orderManager;
        }
        public void OnGet()
        {
            customerid =  Convert.ToInt32(User.FindFirst("id").Value);
            this.Orders = orderManager.GetAllOrdersFromCustomer(customerid);
        }
    }
}
