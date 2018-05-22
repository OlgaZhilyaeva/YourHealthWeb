using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YourHealthWeb.Mvc.Areas.Home.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View("~/Areas/HomeArea/Views/Authorization.cshtml");
        }

        //TODO avtorization
        [HttpPost]
        public IActionResult Login (string emailHelp, string InputPassword)
        {
            ////////////////////////////////
            return View("~/Areas/HomeArea/Views/Authorization.cshtml");
        }


    }
}