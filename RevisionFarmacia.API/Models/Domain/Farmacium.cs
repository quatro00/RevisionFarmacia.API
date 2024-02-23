using System;
using System.Collections.Generic;

namespace RevisionFarmacia.API.Models.Domain;

public partial class Farmacium
{
    public Guid Id { get; set; }

    public string Clave { get; set; } = null!;

    public string Ceco { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int MunicipioId { get; set; }

    public int DistritoId { get; set; }

    public Guid GerenteId { get; set; }

    public string LicenciaSanitaria { get; set; } = null!;

    public int EstatusFarmaciaId { get; set; }

    public DateTime? FechaApertura { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string Telefono { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public Guid UsuarioCreacionId { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public Guid? UsuarioModificacionId { get; set; }

    public virtual EstatusFarmacium EstatusFarmacia { get; set; } = null!;

    public virtual GerenteExcelenciaOperativa Gerente { get; set; } = null!;

    public virtual Municipio Municipio { get; set; } = null!;
}
