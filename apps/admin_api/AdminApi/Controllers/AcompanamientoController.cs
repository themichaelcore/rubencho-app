using Microsoft.AspNetCore.Mvc;
using Rubencho.Application.Pedidos.Queries.GetAcompanamientos;

namespace Rubencho.AdminApi.Controllers;

public class AcompanamientoController : ApiControllerBase
{
    [HttpGet()]
    public async Task<IEnumerable<AcompanamientoDto>> GetAcompanamientos([FromQuery] GetAcompanamientosQuery query)
    {
        return await Mediator.Send(query);
    }
}

