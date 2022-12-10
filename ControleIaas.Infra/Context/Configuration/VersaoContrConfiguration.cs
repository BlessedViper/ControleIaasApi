using ControleIaas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleIaas.Infra.Context.Configuration
{
    public class VersaoContrConfiguration : IEntityTypeConfiguration<VersaoContr>
    {
        public void Configure(EntityTypeBuilder<VersaoContr> builder)
        {
            builder.ToTable("VersaoContratada");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");

            builder
                .Property(a => a.Versao)
                .HasColumnName("Versao")
                .HasColumnType("VARCHAR(30)");

            builder
                .Property(a => a.Deleted)
                .HasColumnName("Deleted")
                .HasColumnType("smallint");
        }

    }
}
