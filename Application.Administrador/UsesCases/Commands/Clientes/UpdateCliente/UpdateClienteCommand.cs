using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Clientes.UpdateCliente
{
    public class UpdateClienteCommand : IRequest
    {
        public Guid ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string NombreTienda { get; set; }
        public string TipoTienda { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }


    }
}
