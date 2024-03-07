using BackPeliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace BackPeliculas.Data.Salas
{
    public class SalaRepository : ISalaRepository
    {
        private readonly AppDbContext _context;

        public SalaRepository(AppDbContext context)
        {
            _context = context;
        }
        public void CreateSala(Sala sala)
        {
            throw new NotImplementedException();
        }

        public void DeleteSala(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Sala>> GetAllSalas()
        {
            return await _context.Salas!.ToListAsync();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
