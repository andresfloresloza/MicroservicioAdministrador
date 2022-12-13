using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Model.Vendedores
{
    public class Vendedor : AggregateRoot
    {
        public PersonNameValue NombreCompleto { get; private set; }
        public UbicacionValue Direccion { get; private set; }
        public PhoneNumberValue Telefono { get; private set; }

        public Vendedor(string nombreCompleto, string direccion, string telefono)
        {
            Id = Guid.NewGuid();
            NombreCompleto = nombreCompleto;
            Direccion = direccion;
            Telefono = telefono;

        }

        public void EditVendedor(string nombreProveedor, string direccionProveedor, string telefonoProveedor)
        {
            NombreCompleto = nombreProveedor;
            Direccion = direccionProveedor;
            Telefono = telefonoProveedor;
        }

        //Only for Entity Framework
        private Vendedor() { }
    }
}
