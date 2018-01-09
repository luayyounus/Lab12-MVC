using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DontWineAboutIt.Models;
using Microsoft.AspNetCore.Mvc;

namespace DontWineAboutIt.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string price, string points)
        {
            return RedirectToAction("Results", new {name, price, points});
        }

        [HttpGet]
        public IActionResult Results(string name, string price, string points)
        {
            ViewBag.Name = name;
            List<Wine> wineList = Wine.FilterWineList(price, points);
            return View(wineList);
        }
    }
}