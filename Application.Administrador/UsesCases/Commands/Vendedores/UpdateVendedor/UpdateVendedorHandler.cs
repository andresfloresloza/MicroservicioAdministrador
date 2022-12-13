using Domain.Administrador.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Vendedores.UpdateVendedor
{
    internal class UpdateVendedorHandler : IRequestHandler<UpdateVendedorCommand>
    {
        private readonly IVendedorRepository _vendedorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateVendedorHandler(IVendedorRepository vendedorRepository, IUnitOfWork unitOfWork)
        {
            _vendedorRepository = vendedorRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateVendedorCommand request, CancellationToken cancellationToken)
        {
            var vendedor = await _vendedorRepository.FindByIdAsync(request.VendedorId);

            if (vendedor == null)
            {
                throw new Exception("Vendedor no encontrado");

            }

            vendedor.EditVendedor(request.NombreVendedor, request.Direccion, request.Telefono);

            await _vendedorRepository.UpdateAsync(vendedor);

            await _unitOfWork.Commit();

            return Unit.Value;
        }
    }
}
