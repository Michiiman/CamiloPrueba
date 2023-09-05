using Dominio;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("persona");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.Apellido)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.Edad)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnType("int");

            builder.HasOne(p => p.TipoNomina)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoNominaFk);

            builder.HasOne(p => p.Equipo)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdEquipoFk);

            builder.HasOne(p => p.Jugador)
            .WithOne(p => p.Persona)
            .HasForeignKey<Jugador>(p => p.IdPersonaFk);

        }
    }
}