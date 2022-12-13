using Infrastructure.Administrador.EF.ReadModel;
using Infrastructure.Administrador.EF.Config.ReadConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Administrador.EF.Context
{
    internal class ReadDbContext : DbContext
    {
        public virtual DbSet<ClienteReadModel> Clientes{ get; set; }
        public virtual DbSet<ChoferReadModel> Choferes { get; set; }
        public virtual DbSet<VendedorReadModel> Vendedores { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<ClienteReadModel>(new ClienteReadConfig());
            modelBuilder.ApplyConfiguration<ChoferReadModel>(new ChoferReadConfig());
            modelBuilder.ApplyConfiguration<VendedorReadModel>(new VendedorReadConfig());

        }
    }
}