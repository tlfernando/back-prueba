using BackPeliculas.Models;

namespace BackPeliculas.Data.Salas
{
    public interface ISalaRepository
    {
        bool SaveChanges();

        Task<IEnumerable<Sala>> GetAllSalas();
        void CreateSala(Sala sala);

        void DeleteSala(int id);
    }
}
