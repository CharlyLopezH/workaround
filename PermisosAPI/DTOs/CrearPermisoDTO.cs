namespace PermisosAPI.DTOs
{
    public class CrearPermisoDTO
    {        

        public int? EmpleadoId { get; set; }

        public DateOnly? Fecha { get; set; }

        public string? SolicitudId { get; set; }

        public string? TipoDia { get; set; }

        public string? Memo { get; set; }

        public string? Notas { get; set; }

        public string? Situacion { get; set; }
    }
}
