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
            // Aqui você pode implementar a lógica para salvar as informações da padaria no banco de dados

            // Exemplo: 
            // var padariaId = PadariaRepository.Save(padaria);

            // Após salvar, você pode redirecionar para uma página de confirmação ou outra ação
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Padaria()
        {
            // Aqui você pode recuperar os dados da padaria do banco de dados ou de outra fonte
            // e passá-los para a view correspondente

            // Exemplo:
            var padaria = new Padaria
            {
                Nome = "Padaria Teste",
                Endereco = "Rua Exemplo, 123",
            };

            return View(padaria);
        }
    }
}
