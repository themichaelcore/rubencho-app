using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;

namespace Rubencho.Application.Pedidos.Queries.GetProductos;

public class GetProductosQueryHandler : IRequestHandler<GetProductosQuery, IEnumerable<ProductoDto>>
{
    private readonly IRubenchoDbContext context;
    private readonly IMapper mapper;

    public GetProductosQueryHandler(IRubenchoDbContext context, IMapper mapper)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<ProductoDto>> Handle(GetProductosQuery request, CancellationToken cancellationToken)
    {
        var source = context.Productos.AsQueryable();

        return await source
            .ProjectTo<ProductoDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}
