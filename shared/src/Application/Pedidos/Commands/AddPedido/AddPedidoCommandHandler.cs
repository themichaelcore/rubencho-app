using Rubencho.Application.Common.Context;
using Rubencho.Domain.Entities;

namespace Rubencho.Application.Pedidos.Commands.AddPedido;

public class AddPedidoCommandHandler : IRequestHandler<AddPedidoCommand>
{
    private readonly IRubenchoDbContext context;
    private readonly IMapper mapper;

    public AddPedidoCommandHandler(IRubenchoDbContext context, IMapper mapper)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task Handle(AddPedidoCommand request, CancellationToken cancellationToken)
    {
        var pedido = mapper.Map<Pedido>(request.BasePedido);
        pedido.Fecha = DateTime.Now;
        pedido.Costo = 0;

        await context.Pedidos.AddAsync(pedido, cancellationToken);

        await context.SaveChangesAsync(cancellationToken);
    }
}
