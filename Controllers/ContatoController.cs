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
                return RedirectToAction("Index", "Home"); // Redireciona para a página inicial após o envio da mensagem
            }

            return View(contato); // Retorna a view com os dados preenchidos em caso de erro de validação
        }
    }
}
