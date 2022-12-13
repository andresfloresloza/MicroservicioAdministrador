using Domain.Administrador.Model.Clientes;
using Domain.Administrador.Model.Vendedores;
using Domain.Administrador.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Clientes.CreateCliente
{
    internal class CreateClienteHandler : IRequestHandler<CreateClienteCommand, Guid>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateClienteHandler(IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            Cliente obj = new Cliente(request.NombreCliente, request.NombreTienda, request.TipoTienda, request.Direccion, request.Telefono);

            await _clienteRepository.CreateAsync(obj);
 
            await _unitOfWork.Commit();

            return obj.Id;
        }
    }
}
