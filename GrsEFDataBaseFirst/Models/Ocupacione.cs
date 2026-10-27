using System;
using System.Collections.Generic;

namespace GrsEFDataBaseFirst.Models;

public partial class Ocupacione
{
    public string Dni { get; set; } = null!;

    public string IdAlbergue { get; set; } = null!;

    public int CantPersonas { get; set; }

    public virtual Cliente DniNavigation { get; set; } = null!;

    public virtual Albergue IdAlbergueNavigation { get; set; } = null!;
}
