using Microsoft.EntityFrameworkCore;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas{get;set;}

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             {
                if(!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = MantenimientoData");
                }
             }
    }
}