using Microsoft.EntityFrameworkCore;
using Desafio_epadoca.Models;

namespace Desafio_epadoca.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Padaria>? Padarias { get; set; }
        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<Cadastro>? Cadastro { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cadastro>(entity =>
            {
                entity.ToTable("cadastro");
                // Adicione outras configurações de modelo, se necessário
            });
        }
    }
}
