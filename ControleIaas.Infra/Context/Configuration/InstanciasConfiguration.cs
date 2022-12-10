using ControleIaas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ControleIaas.Infra.Context.Configuration
{
    public class InstanciasConfiguration : IEntityTypeConfiguration<Instancias>
    {
        public void Configure(EntityTypeBuilder<Instancias> builder)
        {
            builder.ToTable("Instancias");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");

            builder
                .Property(a => a.IdMaquina)
                .HasColumnName("IdMaquina")
                .HasColumnType("INT");

            builder
                .Property(a => a.Instancia)
                .HasColumnName("Instancia")
                .HasColumnType("VARCHAR(150)");

            builder
               .Property(a => a.Banco)
               .HasColumnName("Banco")
               .HasColumnType("VARCHAR(100)");

            builder
                .Property(a => a.Usuario)
                .HasColumnName("Usuario")
                .HasColumnType("VARCHAR(50)");

            builder
                .Property(a => a.Senha)
                .HasColumnName("Senha")
                .HasColumnType("VARCHAR(100)");


            builder
                .Property(a => a.Deleted)
                .HasColumnName("Deleted")
                .HasColumnType("smallint");

            builder
                .HasOne(m => m.Maquina)
                .WithMany(i => i.Instancia)
                .HasForeignKey(m => m.IdMaquina);
        }

    }
}
