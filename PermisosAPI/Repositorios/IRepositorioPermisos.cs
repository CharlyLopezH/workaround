using PermisosAPI.Models;

namespace PermisosAPI.Repositorios
{
    public interface IRepositorioPermisos
    {
        Task<int> Crear(Permiso permiso);
        Task<List<Permiso>> ObtenerTodos();
    }
}
