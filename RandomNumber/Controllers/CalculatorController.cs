using Microsoft.AspNetCore.Mvc;
using RandomNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomNumber.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index(string jmeno)
        {
            Kalkulacka kalkulacka = new Kalkulacka();
            ViewBag.Jmeno = jmeno;
            return View(kalkulacka);
        }

        [HttpPost]
        public IActionResult Index(Kalkulacka kalkulacka)
        {
            if (ModelState.IsValid)
            {
                kalkulacka.VypocitejVysledek();
            }
            return View(kalkulacka);
        }
        

       
    }
}
