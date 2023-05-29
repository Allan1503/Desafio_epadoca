using Desafio_epadoca.Models;
using Desafio_epadoca.Data;
using System.Collections.Generic;

namespace Desafio_epadoca.Repositories
{
    public class PadariaRepository : IPadariaRepository
    {
        private readonly AppDbContext? _context;

        public PadariaRepository(AppDbContext? context)
        {
            _context = context;
        }

        public void Add(Padaria padaria)
        {
            _context?.Set<Padaria>().Add(padaria);
            _context?.SaveChanges();
        }

        public void Update(Padaria padaria)
        {
            // Implementação da lógica de atualização
        }

        public void Delete(int id)
        {
            // Implementação da lógica de exclusão
        }

        public Padaria? GetById(int id)
        {
            // Implementação da lógica para obter uma padaria por ID
            return null; // Retorne o objeto Padaria desejado ou null se não for encontrado
        }

        public List<Padaria> GetAll()
        {
            // Implementação da lógica para obter todas as padarias
            return new List<Padaria>(); // Retorne a lista de padarias desejada
        }
    }
}
