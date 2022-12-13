using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Model.Clientes
{
    public class Cliente : AggregateRoot
    {
        public PersonNameValue NombreCompleto { get; private set; }
        public PersonNameValue NombreTienda { get; private set; }
        public PersonNameValue TipoTienda { get; private set; }
        public UbicacionValue Direccion { get; private set; }
        public PhoneNumberValue Telefono { get; private set; }
            
        public Cliente(string nombreCompleto, string nombreTienda, string tipoTienda, string direccion, string telefono)
        {
            Id = Guid.NewGuid();
            NombreCompleto = nombreCompleto;
            NombreTienda = nombreTienda;
            TipoTienda = tipoTienda;
            Direccion = direccion;
            Telefono = telefono;

        }

        public void EditCliente(string nombreCliente, string nombreTiendaCliente, string tipoTiendaCliente, string direccionCliente, string telefonoCliente)
        {
            NombreCompleto = nombreCliente;
            NombreTienda = nombreTiendaCliente;
            TipoTienda = tipoTiendaCliente;
            Direccion = direccionCliente;
            Telefono = telefonoCliente;
        }

        //Only for Entity Framework
        private Cliente() { }
    }
}
