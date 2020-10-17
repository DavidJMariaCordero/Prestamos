using Microsoft.EntityFrameworkCore;
using Prestamos.Entidades;
namespace Prestamos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Moras> Moras { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source = Data/Prestamos.db");
        }
    }
}