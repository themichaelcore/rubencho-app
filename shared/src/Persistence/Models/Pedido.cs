using System;
using System.Collections.Generic;

namespace Rubencho.Persistence.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public DateTime Fecha { get; set; }

    public int IdEstado { get; set; }

    public int IdColaborador { get; set; }

    public string? Observaciones { get; set; }

    public double Costo { get; set; }

    public int? Mesa { get; set; }

    public bool? EsDomicilio { get; set; }

    public virtual Colaborador IdColaboradorNavigation { get; set; } = null!;

    public virtual EstadoPedido IdEstadoNavigation { get; set; } = null!;

    public virtual ICollection<ProductoPedido> ProductoPedidos { get; set; } = new List<ProductoPedido>();
}
