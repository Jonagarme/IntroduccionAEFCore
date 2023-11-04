using AutoMapper;
using IntroduccionAEFCore.DTOs;
using IntroduccionAEFCore.Entidades;

namespace IntroduccionAEFCore.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<GeneroCreacionDTO, Genero>();
        }
    }
}
