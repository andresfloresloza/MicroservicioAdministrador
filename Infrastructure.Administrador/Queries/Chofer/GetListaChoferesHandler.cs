using Application.Administrador.Dto;
using Application.Administrador.UsesCases.Queries.Chofer;
using Infrastructure.Administrador.EF.Context;
using Infrastructure.Administrador.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Queries.Chofer
{
    internal class GetListaChoferesHandler : IRequestHandler<GetListaChoferesQuery, IEnumerable<ChoferDto>>
    {
        private readonly DbSet<ChoferReadModel> choferes;

        public GetListaChoferesHandler(ReadDbContext dbContext)
        {
            choferes = dbContext.Choferes;
        }


        public async Task<IEnumerable<ChoferDto>> Handle(GetListaChoferesQuery request, CancellationToken cancellationToken)
        {
            var query = choferes.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(request.NombreSearchTerm))
            {
                query = query.Where(x => x.NombreCompleto.ToLower().Contains(request.NombreSearchTerm.ToLower()));
            }

            var lista = await query.Select(x => new ChoferDto
            {
                ChoferId = x.Id,
                Nombre = x.NombreCompleto,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Modelo = x.Modelo,
                Marca = x.Marca,
                Placa = x.Placa
            }).ToListAsync();

            return lista;
        }
    }
}
