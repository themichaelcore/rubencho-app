using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;

namespace Rubencho.Application.Pedidos.Queries.GetColaboradores;

public class GetColaboradoresQueryHandler : IRequestHandler<GetColaboradoresQuery, IEnumerable<ColaboradorDto>>
{
    private readonly IRubenchoDbContext context;
    private readonly IMapper mapper;

    public GetColaboradoresQueryHandler(IRubenchoDbContext context, IMapper mapper)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<ColaboradorDto>> Handle(GetColaboradoresQuery request, CancellationToken cancellationToken)
    {
        var source = context.Colaboradores.AsQueryable();

        return await source
            .ProjectTo<ColaboradorDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}
