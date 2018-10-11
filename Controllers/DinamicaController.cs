using System;
using dinamicasAgile.DAO;
using dinamicasAgile.Models;
using Microsoft.AspNetCore.Mvc;

namespace dinamicasAgile.Controllers
{
    public class DinamicaController : Controller
    {
        private readonly DinamicaDao dinamicaDao;

        public DinamicaController(DinamicaDao dinamicaDao)
        {
            this.dinamicaDao = dinamicaDao;
        }

        [HttpGet]
        public IActionResult Nova() {
            return View();
        }

        [HttpPost]
        public IActionResult Nova(Dinamica dinamica) {
            dinamicaDao.Salva(dinamica);
            return View(dinamica);
        }

    }
}