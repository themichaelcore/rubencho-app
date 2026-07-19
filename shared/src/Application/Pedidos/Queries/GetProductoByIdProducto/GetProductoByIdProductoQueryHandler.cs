using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;
using Rubencho.Application.Pedidos.Queries.GetProductos;

namespace Rubencho.Application.Pedidos.Queries.GetProductoByIdProducto;

public class GetProductoByIdProductoQueryHandler : IRequestHandler<GetProductoByIdProductoQuery, ProductoDto>
{
    private readonly IRubenchoDbContext context;
    private readonly IMapper mapper;

    public GetProductoByIdProductoQueryHandler(IRubenchoDbContext context, IMapper mapper)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<ProductoDto> Handle(GetProductoByIdProductoQuery request, CancellationToken cancellationToken)
    {
        var source = context.Productos.AsQueryable();

        return await source
            .ProjectTo<ProductoDto>(mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(x => x.IdProducto == request.IdProducto, cancellationToken);
    }
}
