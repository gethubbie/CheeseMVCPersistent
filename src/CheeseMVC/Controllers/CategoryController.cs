﻿using CheeseMVC.Data;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using CheeseMVC.ViewModels;
using System.Threading.Tasks;

namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            //List<CheeseCategory> allcategories = context.Categories.ToList();
            ViewBag.allcategories = context.Categories.ToList();

            //return View(allcategories);
            return View();

        }

        public IActionResult Add()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();

            //return View();
            return View(addCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                CheeseCategory newCategory = new CheeseCategory
                {
                    Name = addCategoryViewModel.Name

                };

                context.Categories.Add(newCategory);
                context.SaveChanges();

                return Redirect("/Category");
            }
            return View(addCategoryViewModel);
        }
    }
}
