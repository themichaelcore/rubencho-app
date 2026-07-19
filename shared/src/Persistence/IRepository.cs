using Rubencho.Domain.Entities;

namespace Rubencho.Persistence;

public interface IRepository
{
    Producto GetProducto(int id);

    List<Producto> GetProductos();

    Producto AgregarProducto(Producto producto);

    Producto ActualizarProducto(Producto producto);

    void BorrarProducto(int productoId);

    Pedido AgregarPedido(Pedido pedido);
}
