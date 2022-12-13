using Domain.Administrador.Model.Choferes;
using Domain.Administrador.Model.Vendedores;
using Domain.Administrador.Repositories;
using Infrastructure.Administrador.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Administrador.EF.Repository
{
    internal class ChoferRepository : IChoferRepository
    {
        private readonly WriteDbContext _context;

        public ChoferRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Chofer obj)
        {
            await _context.Choferes.AddAsync(obj);
        }

        public async Task<Chofer?> FindByIdAsync(Guid id)
        {
            return await _context.Choferes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task RemoveAsync(Chofer obj)
        {
            _context.Choferes.Remove(obj); 
            return Task.CompletedTask;

        }

        public Task UpdateAsync(Chofer obj)
        {
            _context.Choferes.Update(obj);
            return Task.CompletedTask;
        }
    }
}
