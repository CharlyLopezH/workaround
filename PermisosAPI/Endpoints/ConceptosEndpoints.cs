using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OutputCaching;
using PermisosAPI.DTOs;
using PermisosAPI.Models;
using PermisosAPI.Repositorios;


namespace PermisosAPI.Endpoints
{
    public static class ConceptosEndpoints
    {
        public static RouteGroupBuilder MapConceptos(this RouteGroupBuilder group)
        {
            group.MapPost("/", Crear);
            group.MapGet("/", ObtenerConceptos);
            return group;
        }

        static async Task<Created<ConceptoDTO>> Crear(CrearConceptoDTO crearConceptoDTO,
        IRepositorioConceptos repositorio, IOutputCacheStore outputCacheStore, IMapper mapper)
        {
            var concepto = mapper.Map<Concepto>(crearConceptoDTO);
            var id = await repositorio.Crear(concepto);
            await outputCacheStore.EvictByTagAsync("concepto-get", default);
            var conceptoDTO = mapper.Map<ConceptoDTO>(concepto);
            return TypedResults.Created($"/conceptos/{id}", conceptoDTO);

        }
         static async Task<Ok<List<ConceptoDTO>>> ObtenerConceptos(IRepositorioConceptos repositorio, IMapper mapper)
        {
            var conceptos = await repositorio.ObtenerTodos();
            var conceptosDTO = mapper.Map<List<ConceptoDTO>>(conceptos);
            return TypedResults.Ok(conceptosDTO);
        }
    }
}



