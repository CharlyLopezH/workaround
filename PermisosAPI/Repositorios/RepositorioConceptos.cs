using Microsoft.EntityFrameworkCore;
using PermisosAPI.Models;

namespace PermisosAPI.Repositorios
{
    public class RepositorioConceptos(ApplicationDbContext context) : IRepositorioConceptos
    {
        private readonly ApplicationDbContext context = context;
        public async Task<int> Crear(Concepto concepto)
        {
            context.Add(concepto);
            await context.SaveChangesAsync();
            return (concepto.Id);

        }

        public async Task<List<Concepto>> ObtenerTodos()
        {
            return await context.Conceptos.OrderBy(a => a.Descripcion).ToListAsync();
        }
    }
}
