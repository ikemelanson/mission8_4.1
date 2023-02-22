using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission8_4._1.Models
{
    public class Context : Controller
    {


        //Seed the data 
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" });

            mb.Entity<Forum>().HasData(

                    new Forum
                    {
                        TaskId = 1,
                        CategoryId = 1,
                        Task = "Clean Car",
                        DueDate = 3 - 10 - 2023,
                        Quadrant = "Important Urgent",
                        Completed = false,
                    }
                );
        }
    }
}

