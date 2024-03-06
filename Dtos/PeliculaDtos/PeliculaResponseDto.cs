using BackPeliculas.Models;

namespace BackPeliculas.Dtos.PeliculaDto
{
    public class PeliculaResponseDto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public TimeSpan Duracion { get; set; }
        public string? Sinopsis { get; set; }
        public string? ImagenUrl { get; set; }
    }
}
