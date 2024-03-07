using AutoMapper;
using BackPeliculas.Dtos.EntradaDtos;
using BackPeliculas.Dtos.PeliculaDto;
using BackPeliculas.Models;

namespace BackPeliculas.Profiles
{
    public class EntradaProfile : Profile
    {
        public EntradaProfile()
        {
            CreateMap<Entrada, EntradaResponseDto>();
            CreateMap<EntradaRequestDto, Entrada>();
        }
    }
}
