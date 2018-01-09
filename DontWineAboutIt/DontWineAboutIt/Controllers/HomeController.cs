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
            Wine wine = new Wine();
            List<Wine> wineList = Wine.FilterWineList(price, points);
            return RedirectToAction("Results", wineList);
        }

        [HttpGet]
        public IActionResult Results(List<Wine> list)
        {
            return View(list);
        }
    }
}