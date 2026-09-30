using Microsoft.EntityFrameworkCore;
using ClasesP.Models;
namespace ClasesP.Data   
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Cancion> Canciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Parcial.db");
        }
    }
}
