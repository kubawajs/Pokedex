using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Models;

namespace Pokedex.Api.Data
{
    public class PokedexApiContext : DbContext
    {
        private readonly DbContextOptions<PokedexApiContext> _options;

        public PokedexApiContext (DbContextOptions<PokedexApiContext> options)
            : base(options)
        {
            _options = options;
        }

        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
