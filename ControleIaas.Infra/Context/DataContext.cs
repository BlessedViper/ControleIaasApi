using ControleIaas.Domain.Entities;
using ControleIaas.Infra.Context.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ControleIaas.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }

        public DbSet<Ambientes> Ambientes { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Instancias> Instancias { get; set; }
        public DbSet<Maquinas> Maquinas { get; set; }
        public DbSet<TipoServer> TipoServer { get; set; }
        public DbSet<VersaoContr> VersaoContratada { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region QueryFilter
            modelBuilder.Entity<Ambientes>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<Clientes>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<Instancias>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<Maquinas>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<TipoServer>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<VersaoContr>().HasQueryFilter(x => !x.Deleted);
            #endregion

            #region Configuration
            modelBuilder.ApplyConfiguration(new AmbientesConfiguration());
            modelBuilder.ApplyConfiguration(new ClientesConfiguration());
            modelBuilder.ApplyConfiguration(new InstanciasConfiguration());
            modelBuilder.ApplyConfiguration(new MaquinasConfiguration());
            modelBuilder.ApplyConfiguration(new TipoServerConfiguration());
            modelBuilder.ApplyConfiguration(new VersaoContrConfiguration());
            #endregion
        }
        public void DeatchAllEntities()
        {
            var changedEntrieCopy = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                .ToList();
            foreach (var entry in changedEntrieCopy)
                entry.State = EntityState.Detached;
        }


    }
}
