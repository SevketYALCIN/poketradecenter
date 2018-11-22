using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokeTradeCenter.Areas.Identity.Data;
using PokeTradeCenter.Models;

namespace PokeTradeCenter.Models
{
    public class PokeTradeCenterContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<PokeTradeCenterUser>
    {
        public PokeTradeCenterContext(DbContextOptions<PokeTradeCenterContext> options)
            : base(options)
        {
        }

        public DbSet<PokeTradeCenter.Models.Ad> Ad { get; set; }
        public DbSet<PokeTradeCenter.Models.Pokemon> Pokemon { get; set; }
        public DbSet<PokeTradeCenter.Models.PokemonMove> PokemonMove { get; set; }
        public DbSet<PokeTradeCenter.Models.PokemonNature> PokemonNature { get; set; }
        public DbSet<PokeTradeCenter.Models.MoveType> PokemonMoveType { get; set; }
    }
}
