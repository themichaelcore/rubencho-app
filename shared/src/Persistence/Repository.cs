using Dapper;
using Microsoft.Extensions.Configuration;
using Rubencho.Domain.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Rubencho.Persistence;

public class Repository : IRepository
{
    private readonly IDbConnection _bd;

    public Repository(IConfiguration configuration)
    {
        _bd = new SqlConnection(configuration.GetConnectionString("RubenchoBackEndAPIContext"));
    }

    public Producto AgregarProducto(Producto producto)
    {
        var sql = "INSERT INTO Producto(Nombre, Precio) VALUES(@Nombre, @Precio)"
            + " SELECT CAST(SCOPE_IDENTITY() as int);";
        var id = _bd.Query<int>(sql, new
        {
            producto.Nombre,
            producto.Precio
        }).Single();
        producto.IdProducto = id;
        return producto;
    }

    public Producto ActualizarProducto(Producto producto)
    {
        var sql = "UPDATE Producto SET Nombre = @Nombre, Precio = @Precio"
            + " WHERE ProductoId = @ProductoId";
        _bd.Execute(sql, producto);
        return producto;
    }

    public void BorrarProducto(int productoId)
    {
        var sql = "DELETE FROM Producto WHERE ProductoId=@ProductoId";
        _bd.Execute(sql, new { @ProductoId = productoId });
    }

    public Producto GetProducto(int productoId)
    {
        var sql = "SELECT * FROM Producto WHERE ProductoId=@ProductoId";
        return _bd.Query<Producto>(sql, new { @ProductoId = productoId }).Single();
    }

    public List<Producto> GetProductos()
    {
        var sql = "SELECT * FROM Producto";
        return _bd.Query<Producto>(sql).ToList();
    }


    public Pedido AgregarPedido(Pedido pedido)
    {
        var sql = "INSERT INTO Pedido(Fecha, IdEstado, IdColaborador, Observaciones, Costo, Mesa, EsDomicilio)"
            + " VALUES(@Fecha, @IdEstado, @IdColaborador, @Observaciones, @Costo, @Mesa, @EsDomicilio)"
            + " SELECT CAST(SCOPE_IDENTITY() as int);";
        var id = _bd.Query<int>(sql, new
        {
            pedido.Fecha,
            pedido.IdEstado,
            pedido.IdColaborador,
            pedido.Observaciones,
            pedido.Costo,
            pedido.Mesa,
            pedido.EsDomicilio
        }).Single();
        pedido.IdPedido = id;
        return pedido;
    }
}
