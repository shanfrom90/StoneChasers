using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sailing_Rocks.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SailingRocksContext db = new SailingRocksContext();
            ViewBag.LatestRocks = db.Rocks.OrderByDescending(r => r.Id).Take(6);

            return View();
        }

        public IActionResult Community()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
