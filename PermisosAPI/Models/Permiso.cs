using System;
using System.Collections.Generic;

namespace PermisosAPI.Models;

public partial class Permiso
{
    public int Id { get; set; }

    public int? EmpleadoId { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? SolicitudId { get; set; }

    public string? TipoDia { get; set; }

    public string? Memo { get; set; }

    public string? Notas { get; set; }

    public string? Situacion { get; set; }
}
