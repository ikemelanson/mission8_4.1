using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission8_4._1.Models;
using System;
using Microsoft.EntityFrameworkCore;
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
        [HttpGet]
        public IActionResult AddTasks()
        {
            ViewBag.Categories = context.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult AddTasks(Forum task)
        {
            if (ModelState.IsValid)
            {
                context.Add(task);
                context.SaveChanges();
                return RedirectToAction("Quadrants");
            }

            ViewBag.Categories = context.Categories.ToList();
            return View();
        }
        public IActionResult Quadrants()
        {
            var quadrants = context.Responses
                .Include(x => x.Category)
                .Where(x => x.Completed == false)
                .ToList();
            return View(quadrants);
        }
        [HttpGet]
        public IActionResult Update(int taskid)
        {
            ViewBag.Categories = context.Categories.ToList();

            var task = context.Responses.Single(x => x.TaskId == taskid);
            return View("INSERTUPDATEVIEWHERE", task);
        }

        [HttpPost]
        public IActionResult Update(Forum f)
        {
            context.Update(f);
            context.SaveChanges();

            return RedirectToAction("Quadrants");
        }
        [HttpGet]
        public IActionResult Delete(int taskid)
        {
            var task = context.Responses.Single(x => x.TaskId == taskid);
            return View(task);
        }
        [HttpPost]
        public IActionResult Delete(Forum f)
        {
            context.Responses.Remove(f);
            context.SaveChanges();
            return RedirectToAction("Quadrants");
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    }

}
