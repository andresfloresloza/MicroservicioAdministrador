using Application.Administrador.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UsesCases.Queries.Vendedor
{
    public class GetListaVendedoresQuery : IRequest<IEnumerable<VendedorDto>>
    {
        public string NombreSearchTerm { get; set; }
    }
}