using Desafio_epadoca.Models;
using Desafio_epadoca.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_epadoca.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        [HttpPost]
        public IActionResult EnviarMensagem(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepository.Add(contato);
                return RedirectToAction("Index", "Home");
            }

            return View(contato);
        }
    }
}