
using BolaoBrasileirao.Models;
using Microsoft.EntityFrameworkCore;

namespace BolaoBrasileirao.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Rodada> Rodadas { get; set; } = null!;
    }
}
