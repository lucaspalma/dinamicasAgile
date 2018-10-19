using Microsoft.AspNetCore.Mvc;

namespace dinamicasAgile.Controllers
{
    public class ExemploController : Controller
    {

        [HttpGet]
        public IActionResult FormNovo(){
            return View();
        }
    }
}