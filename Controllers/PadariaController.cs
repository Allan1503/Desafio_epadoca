using Microsoft.AspNetCore.Mvc;
using Epadoca.Models;

namespace Epadoca.Controllers
{
    public class PadariaController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Padaria padaria)
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Padaria()
        {

            var padaria = new Padaria
            {
                Nome = "Padaria Teste",
                Endereco = "Rua Exemplo, 123",
            };

            return View(padaria);
        }
    }
}
