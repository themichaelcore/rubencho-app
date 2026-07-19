namespace Rubencho.Application.Pedidos.Queries.GetOrden;

public class OrdenDto
{
    public DateTime Fecha { get; set; }

    //public required bool EsDomicilio { get; set; }

    public int Mesa { get; set; }

    public int Colaborador { get; set; }

    public required List<ProductoDto> ListaProductos { get; set; }

    public string? Observaciones { get; set; }
}
