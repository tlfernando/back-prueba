using BackPeliculas.Models;

namespace BackPeliculas.Data.Peliculas
{
    public interface IPeliculaRepository
    {
        bool SaveChanges();

        Task<IEnumerable<Pelicula>> GetAllPeliculas();

        Pelicula GetPeliculaById(int id);

        void CreatePelicula(Pelicula pelicula);

        void DeletePelicula(int id);
    }
}
