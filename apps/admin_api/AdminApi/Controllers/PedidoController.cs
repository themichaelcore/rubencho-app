using Microsoft.AspNetCore.Mvc;
using Rubencho.Application.Pedidos.Queries.GetPedidos;
using Rubencho.Application.Pedidos.Queries.GetPedidoByIdPedido;
using Rubencho.Application.Pedidos.Commands.AddPedido;

namespace Rubencho.AdminApi.Controllers;

public class PedidoController : ApiControllerBase
{

    [HttpGet()]
    public async Task<IEnumerable<PedidoDto>> GetPedidos([FromQuery] GetPedidosQuery query)
    {
        return await Mediator.Send(query);
    }

    [HttpGet("{id}")]
    public async Task<PedidoDto> GetPedido(int id)
    {
        return await Mediator.Send(new GetPedidoByIdPedidoQuery { IdPedido = id});
    }

    [HttpPost()]
    public async Task<ActionResult> PostPedido(AddPedidoCommand command)
    {
        await Mediator.Send(command);
        return Ok();
    }
}
