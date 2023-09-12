using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using PlayVaultWeb.Data;
using PlayVaultWeb.Models;

namespace PlayVaultWeb.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login model, ApplicationDbContext applicationDbContext)
        {
            using( ApplicationDbContext context = applicationDbContext)
            {
                bool IsValidUser = context.Users.Any(user => user.Email == model.Email && user.Password == model.Password);
                if(IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(model.Name, false);
                    return RedirectToAction("Index", "Games");
                }
                ModelState.AddModelError("", "Invalid Username or Password");
                return View();
            }
            
        }
    }
}
