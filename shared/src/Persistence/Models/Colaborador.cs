using System;
using System.Collections.Generic;

namespace Rubencho.Persistence.Models;

public partial class Colaborador
{
    public int IdColaborador { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
