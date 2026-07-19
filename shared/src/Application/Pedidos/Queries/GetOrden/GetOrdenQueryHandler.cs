using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;

namespace Rubencho.Application.Pedidos.Queries.GetOrden;

public class GetOrdenQueryHandler : IRequestHandler<GetOrdenQuery, IEnumerable<OrdenDto>>
{
    private readonly IRubenchoDbContext context;
    private readonly IMapper mapper;

    public GetOrdenQueryHandler(IRubenchoDbContext context, IMapper mapper)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<OrdenDto>> Handle(GetOrdenQuery request, CancellationToken cancellationToken)
    {
        //var source = context.Ordenes.AsQueryable();

        //return await source
        //    .ProjectTo<OrdenDto>(mapper.ConfigurationProvider)
        //    .OrderBy(x => x.Fecha)
        //    .ToListAsync(cancellationToken);

        return null;
    }
}
