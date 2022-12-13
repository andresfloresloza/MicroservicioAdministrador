using Domain.Administrador.Model.Choferes;
using Domain.Administrador.Model.Vendedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Administrador.Domain
{
    public class TestChofer
    {
        [Fact]
        public void ChoferCreation_Should_Correct()
        {
            var nombre = "Fernando Lazcano Mendez";
            var direccion = "Av. Guapay";
            var telefono = "75612785";
            var modelo = "X152-asd1 Camión";
            var marca = "Foton";
            var placa = "4762-XFA";

            Chofer obj = new Chofer(nombre, direccion, telefono, modelo, marca, placa);

            Assert.NotNull(obj.NombreCompleto);
            Assert.NotNull(obj.Direccion);
            Assert.NotNull(obj.Telefono);
            Assert.NotNull(obj.Modelo);
            Assert.NotNull(obj.Marca);
            Assert.NotNull(obj.Placa);
            Assert.Equal(nombre, obj.NombreCompleto);
            Assert.Equal(direccion, obj.Direccion);
            Assert.Equal(telefono, obj.Telefono);
            Assert.Equal(modelo, obj.Modelo);
            Assert.Equal(marca, obj.Marca);
            Assert.Equal(placa, obj.Placa);
        }
    }
}
