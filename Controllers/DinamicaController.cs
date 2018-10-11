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
            if(ModelState.IsValid) {
                dinamicaDao.Salva(dinamica);
                return RedirectToAction("Visualiza", new {id = dinamica.Id});
            }
            return View(dinamica);
        }

        [HttpGet]
        public IActionResult Visualiza(int id) {
            return View(dinamicaDao.BuscaPorId(id));
        }

    }
}