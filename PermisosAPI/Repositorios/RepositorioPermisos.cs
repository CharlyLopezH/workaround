using Microsoft.EntityFrameworkCore;
using PermisosAPI.Models;

namespace PermisosAPI.Repositorios
{
    public class RepositorioPermisos(ApplicationDbContext context) : IRepositorioPermisos
    {
        private readonly ApplicationDbContext context = context;

        public async Task<int> Crear(Permiso permiso)
        {
            context.Add(permiso);
            await context.SaveChangesAsync();
            return (permiso.Id);
        }

        public async Task<List<Permiso>> ObtenerTodos()
        {
            return await context.Permisos.OrderBy(a => a.Fecha).ToListAsync();

        }
    }
}