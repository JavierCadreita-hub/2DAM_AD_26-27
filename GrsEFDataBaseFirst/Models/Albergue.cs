using System;
using System.Collections.Generic;

namespace GrsEFDataBaseFirst.Models;

public partial class Albergue
{
    public string Id { get; set; } = null!;

    public string IdZona { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int TotalPlazas { get; set; }

    public float Precio { get; set; }

    public virtual Zona IdZonaNavigation { get; set; } = null!;

    public virtual ICollection<Ocupacione> Ocupaciones { get; set; } = new List<Ocupacione>();
}
