using ControleIaas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleIaas.Infra.Context.Configuration
{
    public class ClientesConfiguration : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.ToTable("Clientes");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");

            builder
               .Property(a => a.IdAmbiente)
               .HasColumnName("IdAmbiente")
               .HasColumnType("INT");

            builder
                .Property(a => a.IdVersao)
                .HasColumnName("IdVersao")
                .HasColumnType("INT");

            builder
                .Property(a => a.IdInstancia)
                .HasColumnName("IdInstancia")
                .HasColumnType("INT");

            builder
                .Property(a => a.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(MAX)");

            builder
                .Property(a => a.Deleted)
                .HasColumnName("Deleted")
                .HasColumnType("BIT");

            builder
                .HasOne(a => a.Ambiente)
                .WithMany(c => c.Clientes)
                .HasForeignKey(a => a.IdAmbiente);

            builder
                .HasOne(v => v.Versao)
                .WithMany(c => c.Clientes)
                .HasForeignKey(v => v.IdVersao);

            builder
                .HasOne<Instancias>(i => i.Instancia)
                .WithOne(c => c.Cliente)
                .HasForeignKey<Clientes>(i => i.IdInstancia);


        }

    }
}
