namespace PermisosAPI.DTOs
{
    public class CrearConceptoDTO
    {
        public string Descripcion { get; set; } = null!;

        public string? Fundamento { get; set; }

        public int? DiasDerecho { get; set; }

        public string? Notas { get; set; }

        public string? Clave { get; set; }
    }
}
