using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Api.Models
{
    public class PokedexApiContext : DbContext
    {
        public PokedexApiContext (DbContextOptions<PokedexApiContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
