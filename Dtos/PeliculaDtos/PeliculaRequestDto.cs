using BackPeliculas.Models;

namespace BackPeliculas.Dtos.PeliculaDto
{
    public class PeliculaRequestDto
    {
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public TimeSpan Duracion { get; set; }
        public string? Sinopsis { get; set; }
        public string? ImagenUrl { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }
        public int IdSala { get; set; }
        public List<Sala>? SalasDisponibles { get; set; }
    }
}
