using Infrastructure.Administrador.EF.Config.ReadConfig;
using Infrastructure.Administrador.EF.Config.WriteConfig;
using Microsoft.EntityFrameworkCore;
using Domain.Administrador.Model.Clientes;
using Domain.Administrador.Model.Choferes;
using Domain.Administrador.Model.Vendedores;

namespace Infrastructure.Administrador.EF.Context
{
    internal class WriteDbContext : DbContext
    {
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Chofer> Choferes { get; set; }
        public virtual DbSet<Vendedor> Vendedores { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new ClienteWriteConfig());
            modelBuilder.ApplyConfiguration(new ChoferWriteConfig());
            modelBuilder.ApplyConfiguration(new VendedorWriteConfig());
        }
    }
}
