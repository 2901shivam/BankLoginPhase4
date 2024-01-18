using BankLoginPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankLoginPage.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View(new Login());
        }


        [HttpPost]
        public IActionResult Index(Login login)
        {
            if (login.Username == "Shivam" && login.Email == "shivam@gmail.com" && login.Password == "shivam@123")
            {
                return RedirectToAction("Index", "Home");
            }
            else
                return View("Index",login);
        }

        public IActionResult LogOut()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
