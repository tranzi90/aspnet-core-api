﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultsSamples.Controllers
{
    public class ContentResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sample1()
        {
            // Возвращаем ответ, как простой текст 
            return Content("Hello world", "text/plain");
        }

        public IActionResult Sample2()
        {
            // Возвращаем ответ, как JSON контент
            return Content("[1, 2, 3]", "application/json");
        }
    }
}