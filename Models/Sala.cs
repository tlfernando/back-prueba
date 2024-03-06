using System.ComponentModel.DataAnnotations;

namespace BackPeliculas.Models
{
    public class Sala
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Capacidad { get; set; }
        public List<Entrada>? EntradasDisponibles { get; set; }
    }
}
