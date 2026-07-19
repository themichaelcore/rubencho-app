using Rubencho.Application.Pedidos.Queries.GetPedidos;

namespace Rubencho.Application.Pedidos.Queries.GetPedidoByIdPedido;

public class GetPedidoByIdPedidoQuery : IRequest<PedidoDto>
{
    public int IdPedido { get; set; }
}
