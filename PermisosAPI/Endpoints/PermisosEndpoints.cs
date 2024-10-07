using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OutputCaching;
using PermisosAPI.DTOs;
using PermisosAPI.Models;
using PermisosAPI.Repositorios;

namespace PermisosAPI.EndPoints
{
    public static class PermisosEndpoints
    {
        public static RouteGroupBuilder MapPermisos(this RouteGroupBuilder group)
        {
            group.MapPost("/", Crear);
            group.MapGet("/", ObtenerPermisos);
            return group;
        }

        static async Task<Created<PermisoDTO>> Crear(CrearPermisoDTO crearPermisoDTO,
        IRepositorioPermisos repositorio, IOutputCacheStore outputCacheStore, IMapper mapper)
        {
            var permiso = mapper.Map<Permiso>(crearPermisoDTO);
            var id = await repositorio.Crear(permiso);
            await outputCacheStore.EvictByTagAsync("permiso-get", default);
            var permisoDTO = mapper.Map<PermisoDTO>(permiso);
            return TypedResults.Created($"/adscripciones/{id}", permisoDTO);

        }

        static async Task<Ok<List<PermisoDTO>>> ObtenerPermisos(IRepositorioPermisos repositorio, IMapper mapper)
        {
            var permisos = await repositorio.ObtenerTodos();
            var permisosDTO = mapper.Map<List<PermisoDTO>>(permisos);
            return TypedResults.Ok(permisosDTO);
        }



    }
}
