using Application.Administrador.UseCases.Commands.Choferes.UpdateChofer;
using Application.Administrador.UseCases.Commands.Vendedores.CreateVendedor;
using Application.Administrador.UsesCases.Queries.Chofer;
using Application.UseCases.DeleteChofer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Ventas.Controllers
{
    [Route("api/chofer")]
    [ApiController]
    public class ChoferController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChoferController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchChofer([FromQuery] string? nombre = "")
        {
            var query = new GetListaChoferesQuery
            {
                NombreSearchTerm = nombre
            };
            var result = await _mediator.Send(query);
            return Ok(result);

        }

        [HttpPost]
        public async Task<IActionResult> CreateChofer([FromBody] CreateChoferCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateChofer([FromBody] UpdateChoferCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> EliminarChofer([FromBody] DeleteChoferCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
