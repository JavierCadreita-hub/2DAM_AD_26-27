using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GrsEFDataBaseFirst.Models;

public partial class Gr
{
    public string Id { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
    
    public virtual ICollection<Etapa> Etapas { get; set; } = new List<Etapa>();
}
