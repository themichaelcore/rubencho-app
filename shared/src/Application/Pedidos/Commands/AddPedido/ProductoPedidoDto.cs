using Rubencho.Application.Common.Mappings;
using Rubencho.Domain.Entities;

namespace Rubencho.Application.Pedidos.Commands.AddPedido;

public class ProductoPedidoDto : IMapTo<ProductoPedido>
{
    public int Index { get; set; }

    public int IdProducto { get; set; }

    public int? IdAcompanamiento { get; set; }

    public string? Observaciones { get; set; }


    public void Mapping(Profile profile)
    {
        profile.CreateMap<ProductoPedidoDto, ProductoPedido>();
    }

}
