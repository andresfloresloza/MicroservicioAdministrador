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

namespace Application.UseCases.DeleteCliente
{
    public class DeleteClienteHandler : IRequestHandler<DeleteClienteCommand>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteClienteHandler(IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {
            var obj = await _clienteRepository.FindByIdAsync(request.ClienteId);
            if (obj == null)
            {
                throw new Exception("Cliente no encontrado");
            }
            await _clienteRepository.RemoveAsync(obj);
            await _unitOfWork.Commit();
            return Unit.Value;
        }
    }
}
