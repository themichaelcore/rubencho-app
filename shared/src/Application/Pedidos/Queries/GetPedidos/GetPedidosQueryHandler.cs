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
            //.Include(x => x.IdPedidoNavigation)
            //.Include(x => x.IdAcompanamientoNavigation)
            //.OrderBy(x => x.ProductoPedidos.Select(p => p.IdPedidoNavigation.Fecha).FirstOrDefault())
            //.Select(x => new PedidoDto
            //{
            //    IdPedido = x.IdPedido,
            //    Fecha = x.Fecha,
            //    IdEstado = x.IdEstado,
            //    IdColaborador = x.IdColaborador,
            //    Observaciones = x.Observaciones,
            //    Costo = x.Costo,
            //    Mesa = x.Mesa,
            //    EsDomicilio = x.EsDomicilio,
            //    NombreColaborador = x.IdColaboradorNavigation.Nombre,
            //    ProductoPedidos = new List<ProductoPedidoDto>
            //    {
            //        //new ProductoPedidoDto
            //        //{
            //        //    //IdProducto = x.IdProductoNavigation.IdProducto,
            //        //    NombreProducto = x.ProductoPedidos.Nombre,
            //        //    Acompanamiento = x.IdAcompanamientoNavigation.Nombre,
            //        //    Observaciones = x.Observaciones
            //        //}
            //    }                
            //})
            .ToListAsync(cancellationToken);

        var pedidosResult = mapper.Map<List<PedidoDto>>(pedidos);

        return pedidosResult;
    }
}
