using System.ComponentModel.DataAnnotations;

namespace BackPeliculas.Models
{
    public class Entrada
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula? Pelicula { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public int SalaId { get; set; }
        public Sala? Sala { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Genero { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? NumeroTicket { get; set; }
    }
}
