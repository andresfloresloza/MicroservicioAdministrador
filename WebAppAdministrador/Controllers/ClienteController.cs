using Application.Administrador.UseCases.Commands.Clientes.CreateCliente;
using Application.Administrador.UseCases.Commands.Clientes.UpdateCliente;
using Application.Administrador.UsesCases.Queries.Cliente;
using Application.UseCases.DeleteCliente;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Ventas.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchCliente([FromQuery] string? nombre = "")
        {
            var query = new GetListaClientesQuery
            {
                NombreSearchTerm = nombre
            };
            var result = await _mediator.Send(query);
            return Ok(result);

        }

        [HttpPost]
        public async Task<IActionResult> CreateCliente([FromBody] CreateClienteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCliente([FromBody] UpdateClienteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> EliminarCliente([FromBody] DeleteClienteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
