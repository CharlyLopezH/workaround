using AutoMapper;
using PermisosAPI.DTOs;
using PermisosAPI.Models;

namespace PermisosAPI.Utilidades
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<CrearPermisoDTO, Permiso>();
            CreateMap<Permiso, PermisoDTO>();
        }
    }
}
