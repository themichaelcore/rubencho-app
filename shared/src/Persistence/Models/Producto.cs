using System;
using System.Collections.Generic;

namespace Rubencho.Persistence.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public double Precio { get; set; }

    public int IdCategoriaProducto { get; set; }

    public int Acompanamiento { get; set; }

    public virtual CategoriaProducto IdCategoriaProductoNavigation { get; set; } = null!;

    public virtual ICollection<ProductoPedido> ProductoPedidos { get; set; } = new List<ProductoPedido>();
}
