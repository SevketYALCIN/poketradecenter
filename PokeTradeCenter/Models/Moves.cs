using System;

namespace PokeTradeCenter.Models
{
    public class PokemonMove
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public MoveType Type { get; set; }
    }
}