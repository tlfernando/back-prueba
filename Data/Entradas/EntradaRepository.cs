using BackPeliculas.Data;
using BackPeliculas.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BackEntradas.Data.Entradas
{
    public class EntradaRepository : IEntradaRepository
    {
        private readonly AppDbContext _context;

        public EntradaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateEntradaAsync(Entrada entrada) 
        {
            entrada.NumeroTicket = "234";

            await _context.Entradas.AddAsync(entrada);
        }

        public async Task<bool> SaveChangesAsync() 
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}
