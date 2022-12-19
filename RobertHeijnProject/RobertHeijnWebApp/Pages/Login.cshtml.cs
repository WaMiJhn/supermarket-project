using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RhClassLibrary.Interfaces;
using System.Security.Claims;
using System.Web;

namespace RobertHeijnWebApp.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IAccountManager accountManager;
        public LoginModel(IAccountManager accountManager)
        {
            this.accountManager = accountManager;
        }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }
        public async Task OnPost()
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
					await HttpContext.SignOutAsync();
                    Response.Redirect("/");
				}
                else if (accountManager.LoginValidationCustomer(Username, Password))
                {
					List<Claim> claims = new List<Claim>();
					claims.Add(new Claim("id", accountManager.GetAccountByUsername(Username).Id.ToString()));

					ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
					await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
					Response.Redirect("/Profile");
				}
                else { throw new Exception("The password you entered is incorrect, please try again."); }
            }
            catch (Exception ex)
            {
                Response.WriteAsync(ex.Message);
            }
        }
    }
}
