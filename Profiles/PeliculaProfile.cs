using AutoMapper;
using BackPeliculas.Dtos.PeliculaDto;
using BackPeliculas.Models;

namespace BackPeliculas.Profiles
{
    public class PeliculaProfile: Profile
    {
        public PeliculaProfile() {
            CreateMap<Pelicula, PeliculaResponseDto>();
            CreateMap<PeliculaRequestDto, Pelicula>();
        }
    }
}
