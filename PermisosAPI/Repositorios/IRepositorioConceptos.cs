using PermisosAPI.Models;

namespace PermisosAPI.Repositorios
{
    public interface IRepositorioConceptos
    {
        Task<int> Crear(Concepto concepto);
        Task<List<Concepto>> ObtenerTodos();
    }
}
