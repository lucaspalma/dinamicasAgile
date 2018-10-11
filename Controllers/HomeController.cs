using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dinamicasAgile.Models;
using dinamicasAgile.DAO;

namespace dinamicasAgile.Controllers
{
    public class HomeController : Controller
    {
        private readonly DinamicaDao dinamicaDao;

        public HomeController(DinamicaDao dinamicaDao)
        {
            this.dinamicaDao = dinamicaDao;
        }

        public IActionResult Index()
        {
            return View(dinamicaDao.BuscaTodasApenasComInfosBasicas());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
