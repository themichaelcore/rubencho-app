using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;

namespace Rubencho.Application.Pedidos.Queries.GetAcompanamientos;

public class GetAcompanamientosQueryHandler : IRequestHandler<GetAcompanamientosQuery, IEnumerable<AcompanamientoDto>>
{
    private readonly IRubenchoDbContext context;
    private readonly IMapper mapper;

    public GetAcompanamientosQueryHandler(IRubenchoDbContext context, IMapper mapper)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<AcompanamientoDto>> Handle(GetAcompanamientosQuery request, CancellationToken cancellationToken)
    {
        var source = context.Acompanamientos.AsQueryable();

        return await source
            .ProjectTo<AcompanamientoDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}
