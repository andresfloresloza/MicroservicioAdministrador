using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using System.Collections;
using Domain.Administrador.Repositories;

namespace Application.UseCases.DeleteVendedor
{
    public class DeleteVendedorHandler : IRequestHandler<DeleteVendedorCommand>
    {
        private readonly IVendedorRepository _vendedorRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteVendedorHandler(IVendedorRepository vendedorRepository, IUnitOfWork unitOfWork)
        {
            _vendedorRepository = vendedorRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteVendedorCommand request, CancellationToken cancellationToken)
        {
            var obj = await _vendedorRepository.FindByIdAsync(request.VendedorId);
            if (obj == null)
            {
                throw new Exception("Vendedor no encontrado");
            }
            await _vendedorRepository.RemoveAsync(obj);
            await _unitOfWork.Commit();
            return Unit.Value;
        }
    }
}
