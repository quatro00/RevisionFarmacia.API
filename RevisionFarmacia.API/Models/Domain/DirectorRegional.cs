using System;
using System.Collections.Generic;

namespace RevisionFarmacia.API.Models.Domain;

public partial class DirectorRegional
{
    public Guid Id { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public Guid UsuarioCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public Guid? UsuarioActualizacion { get; set; }

    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();
}
