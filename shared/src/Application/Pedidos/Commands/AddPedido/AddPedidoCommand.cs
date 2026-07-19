using Rubencho.Application.Pedidos.Queries.GetPedidos;

namespace Rubencho.Application.Pedidos.Commands.AddPedido;

public class AddPedidoCommand : IRequest
{
    public AddPedidoDto BasePedido { get; set; }

}
