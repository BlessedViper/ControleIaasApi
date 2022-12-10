using ControleIaas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleIaas.Infra.Context.Configuration
{
    public class AmbientesConfiguration : IEntityTypeConfiguration<Ambientes>
    {
        public void Configure(EntityTypeBuilder<Ambientes> builder)
        {
            builder.ToTable("Ambientes");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");

            builder
                .Property(a => a.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(30)");
            builder
                .Property(a => a.Versao)
                .HasColumnName("Versao")
                .HasColumnType("VARCHAR(18)");

            builder
                .Property(a => a.Deleted)
                .HasColumnName("Deleted")
                .HasColumnType("BIT");
        }

    }
}
