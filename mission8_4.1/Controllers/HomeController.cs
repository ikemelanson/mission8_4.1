using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission8_4._1.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

// Created By: Olivia Morgan
// Devon Wolsleger
// Parker Warner
// Ike Melanson
// Taylor Sabin

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

        public IActionResult Index() //Home page
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
        public IActionResult AddTasks(Forum addTask) //Add new items to the matrix
        {
            if (ModelState.IsValid) //Check if valid
            {
                context.Add(addTask);
                context.SaveChanges();
                return RedirectToAction("Quadrants");
            }

            ViewBag.Categories = context.Categories.ToList();
            return View(addTask);
        }
        [HttpGet]
        public IActionResult Quadrants() // Display matrix
        {
            var quadrants = context.Responses
                .Include(x => x.Category)
                .Where(x => x.Completed == false)
                .ToList();
            return View(quadrants);
        }
        [HttpGet]
        public IActionResult Update(int taskid) // Update a task
        {
            ViewBag.Categories = context.Categories.ToList();

            var task = context.Responses.Single(x => x.TaskId == taskid);
            return View("AddTasks", task);
        }

        [HttpPost]
        public IActionResult Update(Forum f)
        {
            context.Update(f);
            context.SaveChanges();

            return RedirectToAction("Quadrants"); //Redirect back to the tasks matrix after updating record
        }
        [HttpGet]
        public IActionResult Delete(int taskid) //Delete task confirmation page
        {
            var task = context.Responses.Single(x => x.TaskId == taskid);
            return View(task);
        }
        [HttpPost]
        public IActionResult Delete(Forum f)
        {
            context.Responses.Remove(f);
            context.SaveChanges();
            return RedirectToAction("Quadrants"); //Redirect back to the tasks matrix after deleting record
        }
    }

}
