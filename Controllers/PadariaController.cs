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
            // Salvar as informações da padaria no banco de dados

            // Redirecionar para uma página de confirmação ou outra ação
            return RedirectToAction("Index", "Home");
        }
    }
}
