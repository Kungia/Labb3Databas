using Labb_3___Databas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Databas.Data
{
    class LundellsBookstoreContext : DbContext
    {
        public DbSet<Butik> Butiker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Lundells Bookstore;Trusted_Connection=True;");
        
        }
    }
}
