using Desafio_epadoca.Repositories;
using Desafio_epadoca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_epadoca.Controllers
{
    public class PadariaController : Controller
    {
        private readonly IPadariaRepository _padariaRepository;

        public PadariaController(IPadariaRepository padariaRepository)
        {
            _padariaRepository = padariaRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Padaria padaria)
        {
            if (ModelState.IsValid)
            {
                _padariaRepository.Add(padaria);
                return RedirectToAction("Index");
            }

            return View(padaria);
        }

        public IActionResult Index()
        {
            var padarias = _padariaRepository.GetAll();
            return View(padarias);
        }

        public IActionResult Padaria()
        {
            return View();
        }
    }
}
