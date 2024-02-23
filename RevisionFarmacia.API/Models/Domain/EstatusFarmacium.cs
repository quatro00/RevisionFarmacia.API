using System;
using System.Collections.Generic;

namespace RevisionFarmacia.API.Models.Domain;

public partial class EstatusFarmacium
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Farmacium> Farmacia { get; set; } = new List<Farmacium>();
}
