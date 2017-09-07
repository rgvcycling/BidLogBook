using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BidLogBook.Models;
using BidLogBook.Repositories;

namespace BidLogBook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var rep = new MockReadRepository();
            var logs = rep.GetLogsList();
            var log = rep.GetLog(2);


            if (!_signInManager.IsSignedIn(User))
                return RedirectToAction("Login", "Account");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Bid Log Book";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Information";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        private SignInManager<ApplicationUser> _signInManager;

        public HomeController(SignInManager<ApplicationUser> signInMgr)
        {
            _signInManager = signInMgr;
        }
    }
}
