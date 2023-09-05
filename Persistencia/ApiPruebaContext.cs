using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;


namespace Persistencia
{
    public class ApiPruebaContext : DbContext
    {
        public ApiPruebaContext(DbContextOptions<ApiPruebaContext> options):base(options)
        {
        }

        public DbSet<Persona> Personas{ get; set; }
        public DbSet<Pais> Paises{ get; set; }
        public DbSet<Equipo> Equipos{ get; set; }
        public DbSet<Jugador> Jugadores{ get; set; }
        public DbSet<TipoNomina>TipoNominas{ get; set; }
        public DbSet<Posicion> Posiciones{ get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}