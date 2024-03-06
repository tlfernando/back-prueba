using BackPeliculas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackPeliculas.Data
{
    public class AppDbContext: IdentityDbContext<Usuario>
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Pelicula>? Peliculas { get; set; }
        public DbSet<Sala>? Salas { get; set; }
        public DbSet<Entrada>? Entradas { get; set; }
    }
}
