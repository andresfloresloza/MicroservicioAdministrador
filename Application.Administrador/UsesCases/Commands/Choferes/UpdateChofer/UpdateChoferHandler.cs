using Domain.Administrador.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Choferes.UpdateChofer
{
    internal class UpdateChoferHandler : IRequestHandler<UpdateChoferCommand>
    {
        private readonly IChoferRepository _choferRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateChoferHandler(IChoferRepository choferRepository, IUnitOfWork unitOfWork)
        {
            _choferRepository = choferRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateChoferCommand request, CancellationToken cancellationToken)
        {
            var vendedor = await _choferRepository.FindByIdAsync(request.ChoferId);

            if (vendedor == null)
            {
                throw new Exception("Chofer no encontrado");

            }

            vendedor.EditChofer(request.NombreChofer, request.Direccion, request.Telefono, request.Modelo, request.Marca, request.Placa);

            await _choferRepository.UpdateAsync(vendedor);

            await _unitOfWork.Commit();

            return Unit.Value;
        }
    }
}
