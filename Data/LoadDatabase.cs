using BackPeliculas.Models;
using Microsoft.AspNetCore.Identity;

namespace BackPeliculas.Data
{
    public class LoadDatabase
    {
        public static async Task InsertarData(AppDbContext context)
        {
            if (!context.Peliculas!.Any())
            {
                context.Peliculas!.AddRange(
                new Pelicula
                {
                    Titulo = "Avengers",
                    Genero = "Ficción",
                    Sinopsis = "Un grupo de superhéroes se unen para salvar al mundo.",
                    Duracion = TimeSpan.FromHours(2),
                    HoraInicio = DateTime.Now.AddHours(1),
                },
                new Pelicula
                {
                    Titulo = "Jurassic Park",
                    Genero = "Aventura",
                    Sinopsis = "Unos dinosaurios causando caos en un parque tematico poniendo en riesgo la vida de las personas.",
                    Duracion = TimeSpan.FromHours(2),
                    HoraInicio = DateTime.Now.AddHours(2),
                }
                );
            }
            
            
            context.SaveChanges();
        }
    }
}
