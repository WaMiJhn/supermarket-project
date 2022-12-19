using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RobertHeijnWebApp.Pages
{
    [Authorize]
    public class OrdersModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
