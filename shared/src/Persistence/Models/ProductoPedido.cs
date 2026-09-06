using System;
using System.Collections.Generic;

namespace Rubencho.Persistence.Models;

public partial class ProductoPedido
{
    public int IdProductoPedido { get; set; }

    public int IdPedido { get; set; }

    public int IdProducto { get; set; }

    public int IdAcompanamiento { get; set; }

    public string? Observaciones { get; set; }

    public virtual Acompanamiento IdAcompanamientoNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
