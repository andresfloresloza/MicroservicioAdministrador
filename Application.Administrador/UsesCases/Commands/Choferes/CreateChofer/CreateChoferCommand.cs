using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Vendedores.CreateVendedor
{
    public class CreateChoferCommand : IRequest<Guid>
    {
        public string NombreChofer { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

    }
}
