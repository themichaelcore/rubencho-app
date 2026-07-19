using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rubencho.Application.Pedidos.Queries.GetOrden;

namespace Rubencho.AdminApi.Controllers;

//[AllowAnonymous]
public class OrdenController : ApiControllerBase
{
    //public readonly IRepository _repo;

    //public PedidoController(IRepository repo)
    //{
    //    _repo = repo;
    //}


    //[HttpGet("{id}")]
    //public OrdenDto? Get(int id)
    //{
    //    var pedido = new Orden(DateTime.Now, false, 1, 1, null, "Sin cebolla", 200);
    //    var propina = 5m;
    //    return pedido.Map(propina);
    //}


    //[HttpPost("")]
    //public Pedido? Post([FromBody] Pedido pedido)
    //{
    //    return _repo.AgregarPedido(pedido);
    //}

    //[HttpGet()]
    //[Route("[controller]")]
    //public async Task<IEnumerable<OrdenDto>> Orden([FromQuery] GetOrdenQuery query)
    //{
    //    return await Mediator.Send(query);
    //}
}
