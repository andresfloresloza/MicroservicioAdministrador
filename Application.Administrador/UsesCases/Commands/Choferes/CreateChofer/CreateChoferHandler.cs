using Application.Administrador.UseCases.Commands.Vendedores.CreateVendedor;
using Domain.Administrador.Model.Choferes;
using Domain.Administrador.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.UseCases.Commands.Choferes.CreateChofer
{
    internal class CreateChoferHandler : IRequestHandler<CreateChoferCommand, Guid>
    {
        private readonly IChoferRepository _choferRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateChoferHandler(IChoferRepository choferRepository, IUnitOfWork unitOfWork)
        {
            _choferRepository = choferRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateChoferCommand request, CancellationToken cancellationToken)
        {
            Chofer obj = new Chofer(request.NombreChofer, request.Direccion, request.Telefono, request.Modelo, request.Marca, request.Placa);

            await _choferRepository.CreateAsync(obj);
 
            await _unitOfWork.Commit();

            return obj.Id;
        }
    }
}
