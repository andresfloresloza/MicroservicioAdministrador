using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Administrador.Model.Choferes
{
    public class Chofer : AggregateRoot
    {
        public PersonNameValue NombreCompleto { get; private set; }
        public UbicacionValue Direccion { get; private set; }
        public PhoneNumberValue Telefono { get; private set; }

        public VehiculoValue Modelo { get; private set; }
        public VehiculoValue Marca { get; private set; }
        public VehiculoValue Placa { get; private set; }

        public Chofer(string nombreCompleto, string direccion, string telefono, string modelo, string marca, string placa)
        {
            Id = Guid.NewGuid();
            NombreCompleto = nombreCompleto;
            Direccion = direccion;
            Telefono = telefono;
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
        }

        public void EditChofer(string nombreChofer, string direccionChofer, string telefonoChofer, string modeloVehiculo, string marcaVehiculo, string placaVehiculo)
        {
            NombreCompleto = nombreChofer;
            Direccion = direccionChofer;
            Telefono = telefonoChofer;
            Modelo = modeloVehiculo;
            Marca = marcaVehiculo;
            Placa = placaVehiculo;
        }

        //Only for Entity Framework
        private Chofer() { }
    }
}
