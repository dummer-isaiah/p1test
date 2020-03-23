using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private UserRepository _ur = new UserRepository();

        private StoreRepostitory _sr = new StoreRepostitory();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Login(UserViewModel userViewModel)
        {
            bool isUser = false;
            bool isStore = false;
            List<User> ul = _ur.Get();
            List<Store> sl = _sr.Get();
            foreach(var item in ul)
            {
              if(userViewModel.UName == item.UName && userViewModel.Password == item.Password)
              {
                isUser = true;
                TempData["user"] = item.UName;
              }
            }

            foreach(var item in sl)
            {
              if(userViewModel.UName == item.UName && userViewModel.Password == item.Password)
              {
                isStore = true;
                TempData["store"] = item.UName;
              }
            }

            if(isUser)
            {
              return View("Navigate");
            }
            else if(isStore)
            {
              return View("Navigate2");
            }
            else
            {
              return View("FailedLogin");
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
