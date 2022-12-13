using Domain.Administrador.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Clientes.UpdateCliente
{
    internal class UpdateClienteHandler : IRequestHandler<UpdateClienteCommand>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateClienteHandler(IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
        {
            var vendedor = await _clienteRepository.FindByIdAsync(request.ClienteId);

            if (vendedor == null)
            {
                throw new Exception("Cliente no encontrado");

            }

            vendedor.EditCliente(request.NombreCliente, request.NombreTienda, request.TipoTienda, request.Direccion, request.Telefono);

            await _clienteRepository.UpdateAsync(vendedor);

            await _unitOfWork.Commit();

            return Unit.Value;
        }
    }
}
