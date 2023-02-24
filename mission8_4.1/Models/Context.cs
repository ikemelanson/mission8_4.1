﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission8_4._1.Models
{
    public class Context : DbContext
    {
        //Constructor 
        public Context (DbContextOptions<Context> options) : base (options)
        {

        }

        public DbSet<Forum> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

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
                        DueDate = "2023-02-26",
                        Quadrant = "1",
                        Completed = false,
                    },
                    new Forum
                    {
                        TaskId = 2,
                        CategoryId = 4,
                        Task = "Finish Project",
                        DueDate = "2023-02-24",
                        Quadrant = "4",
                        Completed = false,
                    }
                );
        }
    }
}

