using Domain.Administrador.Model.Choferes;
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
    internal class ChoferWriteConfig : IEntityTypeConfiguration<Chofer>
    {
        public void Configure(EntityTypeBuilder<Chofer> builder)
        {
            builder.ToTable("Chofer");
            
            builder.Property(x => x.Id).HasColumnName("choferId");


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
            var vehiculoConverter = new ValueConverter<VehiculoValue, string>(
                vehiculoValue => vehiculoValue.Name,
                stringValue => new VehiculoValue(stringValue)
            );

            builder.Property(x => x.NombreCompleto)
                .HasConversion(nombreConverter)
                .HasColumnName("nombreCompleto");

            builder.Property(x => x.Direccion)
                .HasConversion(ubicacionConverter)
                .HasColumnName("direccion");

            builder.Property(x => x.Telefono)
                .HasConversion(phoneConverter)
                .HasColumnName("telefono");

            builder.Property(x => x.Modelo)
                .HasConversion(vehiculoConverter)
                .HasColumnName("modelo");

            builder.Property(x => x.Marca)
                .HasConversion(vehiculoConverter)
                .HasColumnName("marca");

            builder.Property(x => x.Placa)
                .HasConversion(vehiculoConverter)
                .HasColumnName("placa");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
