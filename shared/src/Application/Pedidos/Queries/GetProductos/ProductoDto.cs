using Rubencho.Application.Common.Mappings;
using Rubencho.Domain.Entities;

namespace Rubencho.Application.Pedidos.Queries.GetProductos;

public class ProductoDto : IMapFrom<Producto>
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public double Precio { get; set; }

    public int IdCategoriaProducto { get; set; }

    public int Acompanamiento { get; set; }

    //public virtual CategoriaProducto IdCategoriaProductoNavigation { get; set; } = null!;

    //public virtual ICollection<ProductoPedido> ProductoPedidos { get; set; } = new List<ProductoPedido>();

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Producto, ProductoDto>();
    }
}