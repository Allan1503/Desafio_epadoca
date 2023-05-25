using Epadoca.Models;

namespace Epadoca.Repositories
{
    public class PadariaRepository : IPadariaRepository
    {
        private readonly AppDbContext _context;

        public PadariaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Padaria padaria)
        {
            _context.Padarias.Add(padaria);
            _context.SaveChanges();
        }
    }
}
