using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Problema2.Models;

namespace Problema2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vuelo = new Flight();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Flight vuelo)
        {
            Console.WriteLine(vuelo.DepartureDate);

            return View();
        }
    }
}
