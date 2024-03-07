using BackPeliculas.Models;
using Microsoft.AspNetCore.Identity;

namespace BackPeliculas.Data
{
    public class LoadDatabase
    {
        public static async Task InsertarData(AppDbContext context, UserManager<Usuario> usuarioManager)
        {
            if (!usuarioManager.Users.Any())
            {
                var usuario = new Usuario
                {
                    Nombre = "Luis",
                    Apellido = "Torres",
                    Email = "mail@gmail.com",
                    UserName = "USERDEMO",
                    Telefono = "123456789"
                };
                await usuarioManager.CreateAsync(usuario, "PasswordMi95*Contra123[]");
            }
            if (!context.Peliculas!.Any())
            {
                context.Peliculas!.AddRange(
                new Pelicula
                {
                    Titulo = "Avengers",
                    Genero = "A",
                    Sinopsis = "Un grupo de superhéroes se unen para salvar al mundo.",
                    Duracion = TimeSpan.FromHours(2),
                    HoraInicio = TimeSpan.FromHours(5),
                    HoraFin = TimeSpan.FromHours(7),
                    ImagenUrl = "",
                    IdSala = 1
                },
                new Pelicula
                {
                    Titulo = "Jurassic Park",
                    Genero = "B",
                    Sinopsis = "Unos dinosaurios causando caos en un parque tematico poniendo en riesgo la vida de las personas.",
                    Duracion = TimeSpan.FromHours(2),
                    HoraInicio = TimeSpan.FromHours(5),
                    HoraFin = TimeSpan.FromHours(7),
                    ImagenUrl = "",
                    IdSala = 1
                },
                new Pelicula
                {
                    Titulo = "Rey León",
                    Genero = "C",
                    Sinopsis = "Pel{icula de dibujos animados para niños.",
                    Duracion = TimeSpan.FromHours(1),
                    HoraInicio = TimeSpan.FromHours(2),
                    HoraFin = TimeSpan.FromHours(3),
                    ImagenUrl = "",
                    IdSala = 2
                }
                );
            }
            if (!context.Salas!.Any())
            {
                context.Salas!.AddRange(
                new Sala
                {
                    Nombre= "Sala A",
                    Capacidad= 100,
                    NroEntradas = 10
                },
                new Sala
                {
                    Nombre = "Sala B",
                    Capacidad = 100,
                    NroEntradas = 30
                }
                );
            }

            context.SaveChanges();
        }
    }
}
