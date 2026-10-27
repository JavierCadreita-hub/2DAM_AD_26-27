using System;
using System.Collections.Generic;

namespace GrsEFDataBaseFirst.Models;

public partial class Zona
{
    public string Id { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Albergue> Albergues { get; set; } = new List<Albergue>();

    public virtual ICollection<Etapa> Etapas { get; set; } = new List<Etapa>();
}
