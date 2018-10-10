using System;
using dinamicasAgile.Models;
using Microsoft.AspNetCore.Mvc;

namespace dinamicasAgile.Controllers
{
    public class DinamicaController : Controller
    {

        [HttpGet]
        public IActionResult Nova() {
            return View();
        }

        [HttpPost]
        public IActionResult Nova(Dinamica dinamica) {
            
            return View(dinamica);
        }

    }
}