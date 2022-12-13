using Application.Administrador.UseCases.Commands.Vendedores.CreateVendedor;
using Application.Administrador.UseCases.Commands.Vendedores.UpdateVendedor;
using Application.Administrador.UsesCases.Queries.Vendedor;
using Application.UseCases.DeleteVendedor;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Ventas.Controllers
{
    [Route("api/vendedor")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VendedorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchVendedor([FromQuery] string? nombre = "")
        {
            var query = new GetListaVendedoresQuery
            {
                NombreSearchTerm = nombre
            };
            var result = await _mediator.Send(query);
            return Ok(result);

        }

        [HttpPost]
        public async Task<IActionResult> CreateVendedor([FromBody] CreateVendedorCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateVendedor([FromBody] UpdateVendedorCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> EliminarVendedor([FromBody] DeleteVendedorCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
