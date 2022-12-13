using Application.Administrador.Dto;
using Application.Administrador.UsesCases.Queries.Chofer;
using Application.Administrador.UsesCases.Queries.Cliente;
using Domain.Administrador.Model.Clientes;
using Infrastructure.Administrador.EF.Context;
using Infrastructure.Administrador.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Queries.Cliente
{
    internal class GetListaClientesHandler : IRequestHandler<GetListaClientesQuery, IEnumerable<ClienteDto>>
    {
        private readonly DbSet<ClienteReadModel> clientes;

        public GetListaClientesHandler(ReadDbContext dbContext)
        {
            clientes = dbContext.Clientes;
        }


        public async Task<IEnumerable<ClienteDto>> Handle(GetListaClientesQuery request, CancellationToken cancellationToken)
        {
            var query = clientes.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(request.NombreSearchTerm))
            {
                query = query.Where(x => x.NombreCompleto.ToLower().Contains(request.NombreSearchTerm.ToLower()));
            }

            var lista = await query.Select(x => new ClienteDto
            {
                ClienteId = x.Id,
                Nombre = x.NombreCompleto,
                NombreTienda = x.NombreTienda,
                TipoTienda = x.TipoTienda,
                Direccion = x.Direccion,
                Telefono = x.Telefono
                
            }).ToListAsync();

            return lista;
        }
    }
}
