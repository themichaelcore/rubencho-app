using Rubencho.Application.Common.Mappings;
using Rubencho.Application.Pedidos.Commands.AddPedido;
using Rubencho.Domain.Entities;

namespace Rubencho.Application.Pedidos.Queries.GetPedidos;

public class AddPedidoDto : IMapTo<Pedido>
{
    //public int IdPedido { get; set; }

    //public DateTime Fecha { get; set; }

    public int IdEstado { get; set; }

    public int IdColaborador { get; set; }

    public string? Observaciones { get; set; }

    public double Costo { get; set; }

    public int? Mesa { get; set; }

    public bool? EsDomicilio { get; set; }
    public virtual ICollection<ProductoPedidoDto> ProductoPedidos { get; set; } = new List<ProductoPedidoDto>();

    public void Mapping(Profile profile)
    {
        profile.CreateMap<AddPedidoDto, Pedido>()
            //.IgnoreAuditory()
            //.IgnoreRowVersion()
            //.IgnoreSequence()
            .ForMember(d => d.IdPedido, opt => opt.Ignore());
    }
}