using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace GrsEFDataBaseFirst.Models;

public partial class Etapa
{
    public string IdGr { get; set; } = null!;

    public int NumEtapa { get; set; }

    public string IdZona { get; set; } = null!;

    public int? Km { get; set; }

    public int? Desnivel { get; set; }

    
    public virtual Gr IdGrNavigation { get; set; } = null!;


    public virtual Zona IdZonaNavigation { get; set; } = null!;
}
