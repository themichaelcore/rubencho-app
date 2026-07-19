using Rubencho.Application.Common.Mappings;
using Rubencho.Domain.Entities;

namespace Rubencho.Application.Pedidos.Queries.GetColaboradores;

public class ColaboradorDto : IMapFrom<Colaborador>
{
    public int IdColaborador { get; set; }

    public string? Nombre { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Colaborador, ColaboradorDto>();
            //.ForMember(c => c.IdColaborador, o => o.MapFrom(s => s.IdColaborador))
            //.ForMember(c => c.Nombre, o => o.MapFrom(s => s.Nombre));
            //.ForMember(c => c., option => option.Ignore());
    }
}
