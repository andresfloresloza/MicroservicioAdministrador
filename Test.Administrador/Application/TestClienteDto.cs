using Application.Administrador.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Administrador.Application
{
    public class TestClienteDto
    {
        [Fact]
        public void ClienteDtoCreation_Should_Correct()
        {
            var clienteId = Guid.NewGuid();
            var nombre = "José Limachi Peredo";
            var nombreTienda = "Fidalga";
            var tipoTienda = "Supermercado";
            var direccion = "Av. Paragua 2do Anillo";
            var telefono = "73568245";


            ClienteDto obj = new ClienteDto();


            obj.ClienteId = clienteId;
            obj.Nombre = nombre;
            obj.NombreTienda = nombreTienda;
            obj.TipoTienda = tipoTienda;
            obj.Direccion = direccion;
            obj.Telefono = telefono;


            Assert.Equal(clienteId, obj.ClienteId);
            Assert.Equal(nombre, obj.Nombre);
            Assert.Equal(nombreTienda, obj.NombreTienda);
            Assert.Equal(tipoTienda, obj.TipoTienda);
            Assert.Equal(direccion, obj.Direccion); 
            Assert.Equal(telefono, obj.Telefono);
        }
    }
}