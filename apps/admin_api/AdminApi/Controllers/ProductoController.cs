using Microsoft.AspNetCore.Mvc;
using Rubencho.Application.Pedidos.Queries.GetProductoByIdProducto;
using Rubencho.Application.Pedidos.Queries.GetProductos;

namespace Rubencho.AdminApi.Controllers;

public class ProductoController : ApiControllerBase
{
    [HttpGet()]
    public async Task<IEnumerable<ProductoDto>> GetProductos([FromQuery] GetProductosQuery query)
    {
        return await Mediator.Send(query);
    }

    [HttpGet("{id}")]
    public async Task<ProductoDto> GetProducto(int id)
    {
        return await Mediator.Send(new GetProductoByIdProductoQuery { IdProducto = id });
    }
}
