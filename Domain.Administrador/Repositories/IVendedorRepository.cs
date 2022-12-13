using Domain.Administrador.Model.Vendedores;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Repositories
{
    public interface IVendedorRepository : IRepository<Vendedor, Guid>
    {
        Task UpdateAsync(Vendedor obj);

        Task RemoveAsync(Vendedor obj);

    }
}
