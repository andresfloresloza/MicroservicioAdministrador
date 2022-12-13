using Domain.Administrador.Model.Vendedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Administrador.Domain
{
    public class TestVendedor
    {
        [Fact]
        public void VendedorCreation_Should_Correct()
        {
            var nombre = "Luis Andres Flores Loza";
            var direccion = "Av. Cumavi";
            var telefono = "76680886";

            Vendedor obj = new Vendedor(nombre, direccion,telefono);

            Assert.NotNull(obj.NombreCompleto);
            Assert.NotNull(obj.Direccion);
            Assert.NotNull(obj.Telefono);
            Assert.Equal(nombre, obj.NombreCompleto);
            Assert.Equal(direccion, obj.Direccion);
            Assert.Equal(telefono, obj.Telefono);
        }
    }
}
