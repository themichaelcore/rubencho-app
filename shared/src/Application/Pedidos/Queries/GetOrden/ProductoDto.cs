namespace Rubencho.Application.Pedidos.Queries.GetOrden;

public class ProductoDto
{
    public int Codigo { get; set; }

    public required string Nombre { get; set; }

    public decimal Precio { get; set; }
}
