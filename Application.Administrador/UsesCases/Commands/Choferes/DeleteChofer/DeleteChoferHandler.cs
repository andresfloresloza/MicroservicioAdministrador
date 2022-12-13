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
using Application.UseCases.DeleteChofer;

namespace Application.UseCases.DeleteChofer
{
    public class DeleteChoferHandler : IRequestHandler<DeleteChoferCommand>
    {
        private readonly IChoferRepository _choferRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteChoferHandler(IChoferRepository choferRepository, IUnitOfWork unitOfWork)
        {
            _choferRepository = choferRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteChoferCommand request, CancellationToken cancellationToken)
        {
            var obj = await _choferRepository.FindByIdAsync(request.ChoferId);
            if (obj == null)
            {
                throw new Exception("Chofer no encontrado");
            }
            await _choferRepository.RemoveAsync(obj);
            await _unitOfWork.Commit();
            return Unit.Value;
        }
    }
}
