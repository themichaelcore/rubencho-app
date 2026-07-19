using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;
using Rubencho.Application.Pedidos.Queries.GetPedidos;

namespace Rubencho.Application.Pedidos.Queries.GetPedidoByIdPedido;

public class GetPedidoByIdPedidoQueryHandler : IRequestHandler<GetPedidoByIdPedidoQuery, PedidoDto>
{
    private readonly IRubenchoDbContext context;
    private readonly IMapper mapper;

    public GetPedidoByIdPedidoQueryHandler(IRubenchoDbContext context, IMapper mapper)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<PedidoDto> Handle(GetPedidoByIdPedidoQuery request, CancellationToken cancellationToken)
    {
        var source = context.Pedidos.AsQueryable();

        return await source
            .ProjectTo<PedidoDto>(mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(x => x.IdPedido == request.IdPedido, cancellationToken);

        //return await source
        //    .ProjectTo<PedidoDto>(mapper.ConfigurationProvider)
        //    .FirstOrDefaultAsync(x => x.IdPedido == request.IdPedido, cancellationToken) ?? throw new NotFoundException(nameof(Pedido), request.IdPedido);
    }
}
