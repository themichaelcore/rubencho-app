using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rubencho.Domain.Entities;

public partial class CategoriaProducto
{
    [Key]
    public int IdCategoriaProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
