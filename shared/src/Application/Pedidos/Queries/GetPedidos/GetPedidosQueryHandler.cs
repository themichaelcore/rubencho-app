using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;

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
        var source = context.Pedidos.AsQueryable();

        return await source
            .ProjectTo<PedidoDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Fecha)
            .ToListAsync(cancellationToken);
    }
}
