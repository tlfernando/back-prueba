using System.Threading.Tasks;
using BackPeliculas.Models;

namespace BackEntradas.Data.Entradas
{
    public interface IEntradaRepository
    {
        Task<bool> SaveChangesAsync();
        Task CreateEntradaAsync(Entrada entrada); 
    }
}
