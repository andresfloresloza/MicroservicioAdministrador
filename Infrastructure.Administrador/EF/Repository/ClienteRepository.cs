using Domain.Administrador.Model.Clientes;
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
    internal class ClienteRepository : IClienteRepository
    {
        private readonly WriteDbContext _context;

        public ClienteRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Cliente obj)
        {
            await _context.Clientes.AddAsync(obj);
        }

        public async Task<Cliente?> FindByIdAsync(Guid id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task RemoveAsync(Cliente obj)
        {
            _context.Clientes.Remove(obj); 
            return Task.CompletedTask;

        }

        public Task UpdateAsync(Cliente obj)
        {
            _context.Clientes.Update(obj);
            return Task.CompletedTask;
        }
    }
}
