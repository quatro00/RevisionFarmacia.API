using System;
using System.Collections.Generic;

namespace RevisionFarmacia.API.Models.Domain;

public partial class Estado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Abreviatura { get; set; } = null!;

    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();
}
