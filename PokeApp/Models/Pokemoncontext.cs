using Microsoft.EntityFrameworkCore;

namespace PokeApp.Models
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
        {
        }

        public DbSet<Pokemon> PokemonItems { get; set; }
    }
}
