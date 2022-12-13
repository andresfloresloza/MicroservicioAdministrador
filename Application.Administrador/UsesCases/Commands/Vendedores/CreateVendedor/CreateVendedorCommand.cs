using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Vendedores.CreateVendedor
{
    public class CreateVendedorCommand : IRequest<Guid>
    {
        public string NombreVendedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
