using AutoMapper;
using BackPeliculas.Dtos.SalaDtos;
using BackPeliculas.Models;
namespace BackPeliculas.Profiles
{
    public class SalaProfile: Profile
    {
        public SalaProfile()
        {
            CreateMap<Sala, SalaResponseDto>();
            CreateMap<SalaRequestDto, Sala>();
        }
    }
}
