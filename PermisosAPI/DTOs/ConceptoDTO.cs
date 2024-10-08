namespace PermisosAPI.DTOs
{
    public class ConceptoDTO
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public string? Fundamento { get; set; }

        public int? DiasDerecho { get; set; }

        public string? Notas { get; set; }

        public string? Clave { get; set; }
    }
}
