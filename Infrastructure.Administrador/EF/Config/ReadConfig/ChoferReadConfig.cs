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
    internal class ChoferReadConfig : IEntityTypeConfiguration<ChoferReadModel>
    {
        public void Configure(EntityTypeBuilder<ChoferReadModel> builder)
        {
            builder.ToTable("Chofer");
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).HasColumnName("choferId");

            builder.Property(x => x.NombreCompleto)
                .HasColumnName("nombreCompleto")
                .HasMaxLength(250);

            builder.Property(x => x.Direccion)
                .HasColumnName("direccion")
                .HasMaxLength(250);

            builder.Property(x => x.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(250);

            builder.Property(x => x.Modelo)
                .HasColumnName("modelo")
                .HasMaxLength(250);

            builder.Property(x => x.Marca)
                .HasColumnName("marca")
                .HasMaxLength(250);

            builder.Property(x => x.Placa)
                .HasColumnName("placa")
                .HasMaxLength(250);
        }
    }
}
