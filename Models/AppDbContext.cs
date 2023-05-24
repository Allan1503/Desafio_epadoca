using Microsoft.EntityFrameworkCore;

namespace Epadoca.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Padaria> Padarias { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
