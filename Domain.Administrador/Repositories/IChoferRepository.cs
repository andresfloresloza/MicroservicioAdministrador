using Domain.Administrador.Model.Choferes;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Repositories
{
    public interface IChoferRepository : IRepository<Chofer, Guid>
    {
        Task UpdateAsync(Chofer obj);

        Task RemoveAsync(Chofer obj);

    }
}
