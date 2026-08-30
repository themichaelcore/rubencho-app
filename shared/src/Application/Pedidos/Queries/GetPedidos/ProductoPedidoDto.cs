using Rubencho.Application.Common.Mappings;
using Rubencho.Domain.Entities;

namespace Rubencho.Application.Pedidos.Queries.GetPedidos;

public class ProductoPedidoDto : IMapFrom<ProductoPedido>
{
    public string Producto { get; set; } = null!;

    public string? Acompanamiento { get; set; }

    public string? Observaciones { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<ProductoPedido, ProductoPedidoDto>()
            .ForMember(d => d.Producto, d => d.MapFrom(s => s.IdProductoNavigation.Nombre))
            //.ForMember(d => d.Acompanamiento, d => d.MapFrom(s => s.IdAcompanamientoNavigation.Nombre))
            .ForMember(d => d.Observaciones, d => d.MapFrom(s => s.Observaciones));
    }
}
