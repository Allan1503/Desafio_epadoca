using Microsoft.EntityFrameworkCore;

namespace Desafio_epadoca.Models
{
    public class Desafio_epadocaContext : DbContext
    {
        public DbSet<Padaria>? Padarias { get; set; } // Adicione o operador de anulabilidade ?

        public Desafio_epadocaContext(DbContextOptions<Desafio_epadocaContext> options)
            : base(options)
        {
        }
    }
}

