using Rubencho.Application.Common.Mappings;
using Rubencho.Domain.Entities;

namespace Rubencho.Application.Pedidos.Queries.GetAcompanamientos;

public class AcompanamientoDto : IMapFrom<Acompanamiento>
{
    public int IdAcompanamiento { get; set; }

    public string Nombre { get; set; } = null!;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Acompanamiento, AcompanamientoDto>();
    }
}
