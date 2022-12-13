using Application.Administrador.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Administrador.Application
{
    public class TestChoferDto
    {
        [Fact]
        public void ChoferDtoCreation_Should_Correct()
        {
            var choferId = Guid.NewGuid();
            var nombre = "Carlos Peredo Lino";
            var direccion = "Av. Banzer 10mo Anillo";
            var telefono = "75565134";
            var modelo = "Condor 2018";
            var marca = "Nissan";
            var placa = "4523-PSF";


            ChoferDto obj = new ChoferDto();


            obj.ChoferId = choferId;
            obj.Nombre = nombre;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Modelo = modelo;
            obj.Marca = marca;
            obj.Placa = placa;


            Assert.Equal(choferId, obj.ChoferId);
            Assert.Equal(nombre, obj.Nombre);
            Assert.Equal(direccion, obj.Direccion);
            Assert.Equal(telefono, obj.Telefono);
            Assert.Equal(modelo, obj.Modelo);
            Assert.Equal(marca, obj.Marca);
            Assert.Equal(placa, obj.Placa);
        }
    }
}