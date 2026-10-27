using System;
using System.Collections.Generic;

namespace GrsEFDataBaseFirst.Models;

public partial class Cliente
{
    public string Dni { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Ocupacione> Ocupaciones { get; set; } = new List<Ocupacione>();
}
