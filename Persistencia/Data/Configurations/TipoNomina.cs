using Dominio;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TipoNominaConfiguration : IEntityTypeConfiguration<TipoNomina>
    {
        public void Configure(EntityTypeBuilder<TipoNomina> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("tipoNomina");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.NombreNomina)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}