using BackPeliculas.Models;

namespace BackPeliculas.Token;

public interface IJwtGenerador
{
    string CrearToken(Usuario usuario);
}