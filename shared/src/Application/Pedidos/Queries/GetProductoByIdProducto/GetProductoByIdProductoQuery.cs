using Rubencho.Application.Pedidos.Queries.GetProductos;

namespace Rubencho.Application.Pedidos.Queries.GetProductoByIdProducto;

public class GetProductoByIdProductoQuery : IRequest<ProductoDto>
{
    public int IdProducto { get; set; }
}
