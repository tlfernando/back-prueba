using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackPeliculas.Models
{
    public class Pelicula
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public TimeSpan Duracion { get; set; }
        public string? Sinopsis { get; set; }
        public string? ImagenUrl { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        [Required]
        public int IdSala { get; set; }
        public List<Sala>? SalasDisponibles { get; set; }
    }
}
