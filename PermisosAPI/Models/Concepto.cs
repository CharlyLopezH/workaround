using System;
using System.Collections.Generic;

namespace PermisosAPI.Models;

public partial class Concepto
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Fundamento { get; set; }

    public int? DiasDerecho { get; set; }

    public string? Notas { get; set; }

    public string? Clave { get; set; }
}
