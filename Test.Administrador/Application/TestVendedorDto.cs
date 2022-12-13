using Application.Administrador.Dto;

namespace Test.Administrador.Application
{
    public class TestProductoDto
    {
        [Fact]
        public void VendedorDtoCreation_Should_Correct()
        {
            var vendedorId = Guid.NewGuid();
            var nombre = "Robert Perez Lino";
            var direccion = "Av. Banzer 10mo Anillo";


            VendedorDto obj = new VendedorDto();


            obj.VendedorId = vendedorId;
            obj.Nombre = nombre;
            obj.Direccion = direccion;


            Assert.Equal(vendedorId, obj.VendedorId);
            Assert.Equal(nombre, obj.Nombre);
            Assert.Equal(direccion, obj.Direccion);
        }
    }
}