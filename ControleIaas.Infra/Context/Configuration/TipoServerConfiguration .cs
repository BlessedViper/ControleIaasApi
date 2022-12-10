using ControleIaas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleIaas.Infra.Context.Configuration
{
    public class TipoServerConfiguration : IEntityTypeConfiguration<TipoServer>
    {
        public void Configure(EntityTypeBuilder<TipoServer> builder)
        {
            builder.ToTable("TipoServer");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");

            builder
                .Property(a => a.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("VARCHAR(100)");
            builder
                .Property(a => a.Servicos)
                .HasColumnName("Servicos")
                .HasColumnType("VARCHAR(100)");

            builder
                .Property(a => a.Deleted)
                .HasColumnName("Deleted")
                .HasColumnType("BIT");
        }

    }
}
