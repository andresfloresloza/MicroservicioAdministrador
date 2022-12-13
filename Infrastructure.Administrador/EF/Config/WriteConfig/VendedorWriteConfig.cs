using Domain.Administrador.Model.Vendedores;
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
    internal class VendedorWriteConfig : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.ToTable("Vendedor");
            
            builder.Property(x => x.Id).HasColumnName("vendedorId");


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
