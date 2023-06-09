using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TEST.Entidades.Humano;

namespace TEST.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=TESTS;User Id=sa;Password=sistemas;Trusted_Connection=False;MultipleActiveResultSets=true");
            }
        }
        public DbSet<HumanoEnty> ModelosHumanos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Puedes agregar configuraciones adicionales para tus entidades aquí
        }
    }
}
