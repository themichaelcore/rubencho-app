using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;
using Rubencho.Domain.Enums;
using System.Numerics;

namespace Rubencho.Application.Pedidos.Queries.GetPedidos;

public class GetPedidosQueryHandler : IRequestHandler<GetPedidosQuery, IEnumerable<PedidoDto>>
{
    private readonly IRubenchoDbContext context;
    private readonly IMapper mapper;

    public GetPedidosQueryHandler(IRubenchoDbContext context, IMapper mapper)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<PedidoDto>> Handle(GetPedidosQuery request, CancellationToken cancellationToken)
    {
        var pedidos = await context.Pedidos
            .AsNoTracking()
            .AsQueryable()
            .Include(x => x.IdColaboradorNavigation)
            .Include(x => x.ProductoPedidos)
                .ThenInclude(x => x.IdProductoNavigation)
            .Include(x => x.ProductoPedidos)
                .ThenInclude(x => x.IdAcompanamientoNavigation)
            .ToListAsync(cancellationToken);

        var pedidosResult = mapper.Map<List<PedidoDto>>(pedidos);

        return pedidosResult;
    }
}
