﻿using DrinKing.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DrinKing.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinKing.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }
        public ViewResult List()
        {
            var drinks = _drinkRepository. Drinks;
            return View(drinks);
        }
    }
}
