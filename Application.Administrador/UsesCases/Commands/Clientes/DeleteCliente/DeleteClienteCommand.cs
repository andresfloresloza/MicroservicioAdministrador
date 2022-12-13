using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.DeleteCliente
{
    public class DeleteClienteCommand : IRequest
    {
        public Guid ClienteId { get; set; }
        }
}
