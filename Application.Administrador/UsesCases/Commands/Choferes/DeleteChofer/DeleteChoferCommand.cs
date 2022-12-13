using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.DeleteChofer
{
    public class DeleteChoferCommand : IRequest
    {
        public Guid ChoferId { get; set; }
        }
}
