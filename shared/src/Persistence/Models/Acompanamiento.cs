using System;
using System.Collections.Generic;

namespace Rubencho.Persistence.Models;

public partial class Acompanamiento
{
    public int IdAcompanamiento { get; set; }

    public string Nombre { get; set; } = null!;
}
