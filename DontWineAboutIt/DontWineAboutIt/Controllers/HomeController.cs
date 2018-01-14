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
        public IActionResult Index(string name, Wine wine)
        {
            return RedirectToAction("Results", new {name, wine.Price, wine.Points, wine.Country});
        }

        [HttpGet]
        public IActionResult Results(string name, Wine wine)
        {
            ViewBag.Name = name;

            List<Wine> allWines = Wine.GetWineList();

            // Filtered based on the Price and Points
            allWines = allWines.Where(w => w.Price == wine.Price).Where(w => w.Points == wine.Points).ToList();

            // Filtered based on Country if specified
            if (!String.IsNullOrEmpty(wine.Country))
                allWines = allWines.Where(w => w.Country.ToLower() == wine.Country.ToLower()).ToList();

            return View(allWines);
        }
    }
}