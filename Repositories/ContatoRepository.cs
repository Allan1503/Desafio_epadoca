using Desafio_epadoca.Models;
using Desafio_epadoca.Data;

namespace Desafio_epadoca.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AppDbContext _context;

        public ContatoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Contato contato)
        {
            _context.Set<Contato>().Add(contato);
            _context.SaveChanges();
        }
    }
}
