using Labb_3___Databas.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb_3___Databas.Data
{
    class LundellsBookstoreContext : DbContext
    {
        public DbSet<Butik> Butiker { get; set; }
       // public DbSet<Bok> Böcker { get; set; }
        public DbSet<Lagersaldo> Lagersaldos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var DBserver = optionsBuilder.UseSqlServer("Server=localhost;Database=Lundells Bookstore;Trusted_Connection=True;");

        }
    }
}
