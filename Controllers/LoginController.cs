﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IPT_MVC_Activity.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            if (username == "admin123" && password == "pass@admin123")
            { 
                return RedirectToAction("Index", "Miniatures");
            }
            else if (username == "user123" && password == "pass@user123")
            {
                return RedirectToAction("IndexAlt", "Miniatures");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Credentials");
                return View("Login");
            }
        }

        public IActionResult Index()
        {
            return View();
        }
        // GET: LoginController
        public ActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }

     

    }
}
