using Application.Administrador.Dto;
using Application.Administrador.UsesCases.Queries.Vendedor;
using Infrastructure.Administrador.EF.Context;
using Infrastructure.Administrador.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Queries.Vendedor
{
    internal class GetListaVendedoresHandler : IRequestHandler<GetListaVendedoresQuery, IEnumerable<VendedorDto>>
    {
        private readonly DbSet<VendedorReadModel> vendedores;

        public GetListaVendedoresHandler(ReadDbContext dbContext)
        {
            vendedores = dbContext.Vendedores;
        }


        public async Task<IEnumerable<VendedorDto>> Handle(GetListaVendedoresQuery request, CancellationToken cancellationToken)
        {
            var query = vendedores.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(request.NombreSearchTerm))
            {
                query = query.Where(x => x.NombreCompleto.ToLower().Contains(request.NombreSearchTerm.ToLower()));
            }

            var lista = await query.Select(x => new VendedorDto
            {
                VendedorId = x.Id,
                Nombre = x.NombreCompleto,
                Direccion = x.Direccion,
                Telefono = x.Telefono
            }).ToListAsync();

            return lista;
        }
    }
}
