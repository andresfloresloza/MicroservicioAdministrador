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
    internal class VendedorRepository : IVendedorRepository
    {
        private readonly WriteDbContext _context;

        public VendedorRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Vendedor obj)
        {
            await _context.Vendedores.AddAsync(obj);
        }

        public async Task<Vendedor?> FindByIdAsync(Guid id)
        {
            return await _context.Vendedores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task RemoveAsync(Vendedor obj)
        {
            _context.Vendedores.Remove(obj); 
            return Task.CompletedTask;

        }

        public Task UpdateAsync(Vendedor obj)
        {
            _context.Vendedores.Update(obj);
            return Task.CompletedTask;
        }
    }
}
