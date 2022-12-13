using Infrastructure.Administrador.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Administrador.EF.Config.ReadConfig
{
    internal class ClienteReadConfig : IEntityTypeConfiguration<ClienteReadModel>
    {
        public void Configure(EntityTypeBuilder<ClienteReadModel> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).HasColumnName("clienteId");

            builder.Property(x => x.NombreCompleto)
                .HasColumnName("nombreCompleto")
                .HasMaxLength(250);

            builder.Property(x => x.NombreTienda)
                .HasColumnName("nombreTienda")
                .HasMaxLength(250);

            builder.Property(x => x.TipoTienda)
                .HasColumnName("tipoTienda")
                .HasMaxLength(250);

            builder.Property(x => x.Direccion)
                .HasColumnName("direccion")
                .HasMaxLength(250);

            builder.Property(x => x.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(250);
        }
    }
}
