using ControleIaas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleIaas.Infra.Context.Configuration
{
    public class MaquinasConfiguration : IEntityTypeConfiguration<Maquinas>
    {
        public void Configure(EntityTypeBuilder<Maquinas> builder)
        {
            builder.ToTable("Maquinas");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");

            builder
                .Property(a => a.IdAmbiente)
                .HasColumnName("IdAmbiente")
                .HasColumnType("INT");

            builder
                .Property(a => a.IdTipo)
                .HasColumnName("IdTipo")
                .HasColumnType("INT");

            builder
                .Property(a => a.SO)
                .HasColumnName("SO")
                .HasColumnType("VARCHAR(100)");

            builder
                .Property(a => a.IpPrivado)
                .HasColumnName("IpPrivado")
                .HasColumnType("VARHCAR(50)");

            builder
                .Property(a => a.NomeDns)
                .HasColumnName("NomeDns")
                .HasColumnType("VARCHAR(MAX)");

            builder
                .Property(a => a.PortaRdp)
                .HasColumnName("PortaRdp")
                .HasColumnType("INT");

            builder
                .Property(a => a.Usuario)
                .HasColumnName("Usuario")
                .HasColumnType("VARCHAR(30)");

            builder
                .Property(a => a.Senha)
                .HasColumnName("Senha")
                .HasColumnType("VARCHAR(MAX)");

            builder
                .Property(a => a.Deleted)
                .HasColumnName("Deleted")
                .HasColumnType("BIT");

            builder
                .HasOne(m => m.Ambiente)
                .WithMany(a => a.Maquinas)
                .HasForeignKey(m => m.IdAmbiente);

            builder
                .HasOne(m => m.Tipo)
                .WithMany(t => t.Maquinas)
                .HasForeignKey(m => m.IdTipo);


        }

    }
}
