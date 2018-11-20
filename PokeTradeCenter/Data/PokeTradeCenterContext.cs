using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PokeTradeCenter.Models
{
    public class PokeTradeCenterContext : DbContext
    {
        public PokeTradeCenterContext (DbContextOptions<PokeTradeCenterContext> options)
            : base(options)
        {
        }

        public DbSet<PokeTradeCenter.Models.Ad> Ad { get; set; }
    }
}
