using Domain.Administrador.Model.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Administrador.EF.Config.WriteConfig
{
    internal class ClienteWriteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            
            builder.Property(x => x.Id).HasColumnName("clienteId");


            var nombreConverter = new ValueConverter<PersonNameValue, string>(
                personNameValue => personNameValue.Name,
                stringValue => new PersonNameValue(stringValue)
            );
            var ubicacionConverter = new ValueConverter<UbicacionValue, string>(
                ubicacionValue => ubicacionValue.Name,
                stringValue => new UbicacionValue(stringValue)
            );
            var phoneConverter = new ValueConverter<PhoneNumberValue, string>(
                phoneValue => phoneValue.Number,
                stringValue => new PhoneNumberValue(stringValue)
            );

            builder.Property(x => x.NombreCompleto)
                .HasConversion(nombreConverter)
                .HasColumnName("nombreCompleto");

            builder.Property(x => x.NombreTienda)
                .HasConversion(nombreConverter)
                .HasColumnName("nombreTienda");

            builder.Property(x => x.TipoTienda)
                .HasConversion(nombreConverter)
                .HasColumnName("tipoTienda");

            builder.Property(x => x.Direccion)
                .HasConversion(ubicacionConverter)
                .HasColumnName("direccion");

            builder.Property(x => x.Telefono)
                .HasConversion(phoneConverter)
                .HasColumnName("telefono");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
