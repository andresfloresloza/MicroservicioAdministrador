using Domain.Administrador.Model.Clientes;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Repositories
{
    public interface IClienteRepository : IRepository<Cliente, Guid>
    {
        Task UpdateAsync(Cliente obj);

        Task RemoveAsync(Cliente obj);

    }
}
