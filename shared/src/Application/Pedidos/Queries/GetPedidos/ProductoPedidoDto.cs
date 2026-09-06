using Rubencho.Application.Common.Mappings;
using Rubencho.Domain.Entities;
using Rubencho.Domain.Enums;

namespace Rubencho.Application.Pedidos.Queries.GetPedidos;

public class ProductoPedidoDto : IMapFrom<ProductoPedido>
{
    public int IdProductoPedido { get; set; }

    public int IdPedido { get; set; }

    public int IdProducto { get; set; }

    public string? NombreProducto { get; set; }

    public AcompanamientoId IdAcompanamiento { get; set; }

    public string? Acompanamiento { get; set; }

    public string? Observaciones { get; set; }

    //public virtual Acompanamiento IdAcompanamientoNavigation { get; set; } = null!;

    //public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    //public virtual Producto IdProductoNavigation { get; set; } = null!;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<ProductoPedido, ProductoPedidoDto>()
            .ForMember(d => d.NombreProducto, d => d.MapFrom(s => s.IdProductoNavigation.Nombre))
            .ForMember(d => d.Acompanamiento, d => d.MapFrom(s => s.IdAcompanamientoNavigation != null ? s.IdAcompanamientoNavigation.Nombre : ""))
            .ForMember(d => d.Observaciones, d => d.MapFrom(s => s.Observaciones));
    }
}
