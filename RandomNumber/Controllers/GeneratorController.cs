using Microsoft.AspNetCore.Mvc;
using RandomNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomNumber.Controllers
{
    public class GeneratorController : Controller
    {
        public IActionResult Index()
        {
            Generator generator = new Generator();
            ViewBag.Number = generator.ReturnNumber();
            return View();
        }
    }
}
