using Microsoft.EntityFrameworkCore;
using P138FirstDBMigration.Models;

namespace P138FirstDBMigration.DataAccestLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Marka> Markas { get; set; }

        public DbSet<Model> Models { get; set; }
    }
}
