using System;
using System.Collections.Generic;

namespace RevisionFarmacia.API.Models.Domain;

public partial class Region
{
    public Guid Id { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Activo { get; set; }

    public Guid DirectorId { get; set; }

    public DateTime FechaCreacion { get; set; }

    public Guid UsuarioCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public Guid? UsuarioModificacion { get; set; }

    public virtual DirectorRegional Director { get; set; } = null!;
}
