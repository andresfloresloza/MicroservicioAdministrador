using Domain.Administrador.Model.Clientes;
using Domain.Administrador.Model.Vendedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Administrador.Domain
{
    public class TestCliente
    {
        [Fact]
        public void ClienteCreation_Should_Correct()
        {
            var nombre = "Franz José Flores Loza";
            var nombreTienda = "Fidalga";
            var tipoTienda = "Supermercado";
            var direccion = "Av. Paragua 2do Anillo";
            var telefono = "73568245";

            Cliente obj = new Cliente(nombre, nombreTienda, tipoTienda, direccion, telefono);

            Assert.NotNull(obj.NombreCompleto);
            Assert.NotNull(obj.NombreTienda);
            Assert.NotNull(obj.TipoTienda);
            Assert.NotNull(obj.Direccion);
            Assert.NotNull(obj.Telefono);
            Assert.Equal(nombre, obj.NombreCompleto);
            Assert.Equal(nombreTienda, obj.NombreTienda);
            Assert.Equal(tipoTienda, obj.TipoTienda);
            Assert.Equal(direccion, obj.Direccion);
            Assert.Equal(telefono, obj.Telefono);
        }
    }
}
