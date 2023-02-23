using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission8_4._1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission8_4._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Context context { get; set; }

        public HomeController(ILogger<HomeController> logger, Context x)
        {
            _logger = logger;
            context = x;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Quadrants()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult /*Name of input page here*/ ()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult /*Name of input page here*/ (Forum f)
        //{
        //    context.Add(f);
        //    context.SaveChanges();

        //    return View("Confirmation", f);
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    }

}
