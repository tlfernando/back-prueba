namespace BackPeliculas.Dtos.SalaDtos
{
    public class SalaRequestDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Capacidad { get; set; }
        public int NroEntradas { get; set; }
    }
}
