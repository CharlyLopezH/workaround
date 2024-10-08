using System;
using System.Collections.Generic;

namespace PermisosAPI.Models;

public partial class Solicitudes
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public string Folio { get; set; } = null!;

    public int EmpleadoId { get; set; }

    public string DirAreaNombre { get; set; } = null!;

    public string DirGralNombre { get; set; } = null!;
}
