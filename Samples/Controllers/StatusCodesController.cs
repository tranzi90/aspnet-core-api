﻿using Microsoft.AspNetCore.Mvc;

namespace ActionResultsSamples.Controllers
{
    public class StatusCodesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sample1()
        {
            return StatusCode(200); // возврат указанного статус кода
        }

        public IActionResult Sample2()
        {
            return Ok(); // 200
        }

        public IActionResult Sample3()
        {
            return Created(Request.Path + "/123", new { prop1 = "A", prop2 = "B" }); // 201, ардерс по которому создан ресурс и сам ресурс
        }

        public IActionResult Sample4()
        {
            return BadRequest(); // 400
        }

        public IActionResult Sample5()
        {
            return Unauthorized(); // 401
        }

        public IActionResult Sample6()
        {
            return NotFound(); // 404
        }
    }
}