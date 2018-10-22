using dinamicasAgile.DAO;
using dinamicasAgile.Models;
using Microsoft.AspNetCore.Mvc;

namespace dinamicasAgile.Controllers {
    public class ExemploController : Controller {
        private readonly DinamicaDao dinamicaDao;

        public ExemploController (DinamicaDao dinamicaDao) {
            this.dinamicaDao = dinamicaDao;

        }

        [HttpGet]
        public IActionResult FormNovo () {
            return PartialView ();
        }

        [HttpPost]
        [Route("Exemplo/Adiciona/{idDinamica}")]
        public IActionResult Adiciona (int idDinamica, [FromBody] Exemplo exemplo) {
            if (ModelState.IsValid) {
                dinamicaDao.CadastraExemplo(idDinamica, exemplo);
                return PartialView (exemplo);
            }
            
            return BadRequest(ModelState);
        }
    }
}