using System;
using System.Collections.Generic;

namespace RevisionFarmacia.API.Models.Domain;

public partial class Municipio
{
    public int Id { get; set; }

    public int EstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual ICollection<Farmacium> Farmacia { get; set; } = new List<Farmacium>();
}
