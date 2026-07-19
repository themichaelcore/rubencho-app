using Microsoft.AspNetCore.Mvc;
using Rubencho.Application.Pedidos.Queries.GetColaboradores;

namespace Rubencho.AdminApi.Controllers;

public class ColaboradorController : ApiControllerBase
{
    [HttpGet()]
    public async Task<IEnumerable<ColaboradorDto>> GetColaboradores([FromQuery] GetColaboradoresQuery query)
    {
        return await Mediator.Send(query);
    }
}
