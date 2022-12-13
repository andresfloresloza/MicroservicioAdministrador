using Domain.Administrador.Model.Vendedores;
using Domain.Administrador.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Vendedores.CreateVendedor
{
    internal class CreateVendedorHandler : IRequestHandler<CreateVendedorCommand, Guid>
    {
        private readonly IVendedorRepository _vendedorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateVendedorHandler(IVendedorRepository vendedorRepository, IUnitOfWork unitOfWork)
        {
            _vendedorRepository = vendedorRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateVendedorCommand request, CancellationToken cancellationToken)
        {
            Vendedor obj = new Vendedor(request.NombreVendedor, request.Direccion, request.Telefono);

            await _vendedorRepository.CreateAsync(obj);
 
            await _unitOfWork.Commit();

            return obj.Id;
        }
    }
}
