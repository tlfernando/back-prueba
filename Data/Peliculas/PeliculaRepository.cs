using BackPeliculas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BackPeliculas.Data.Peliculas
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly AppDbContext _context;

        public PeliculaRepository(AppDbContext context)
        {
            _context = context;
        }
        public void CreatePelicula(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public void DeletePelicula(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Pelicula>> GetAllPeliculas()
        {
            return await _context.Peliculas!.ToListAsync();
        }

        public Pelicula GetPeliculaById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
