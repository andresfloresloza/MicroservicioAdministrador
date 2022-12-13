using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Vendedores.UpdateVendedor
{
    public class UpdateVendedorCommand : IRequest
    {
        public Guid VendedorId { get; set; }

        public string NombreVendedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }


    }
}
