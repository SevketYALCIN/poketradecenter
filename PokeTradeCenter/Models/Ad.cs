using System;

namespace PokeTradeCenter.Models
{
    public class Ad
    {
        public int ID { get; set; }
        public Pokemon Pokemon { get; set; }
        public DateTime ReleaseDate { get; set; }
        public PokemonNature Nature { get; set; }
        public int Atk { get; set; }
        public int SpeAtk { get; set; }
        public int Def { get; set; }
        public int SpeDef { get; set; }
        public int Speed { get; set; }
        public int Hp { get; set; }
        public int Level { get; set; }
        public PokemonMove Move1 { get; set; }
        public PokemonMove Move2 { get; set; }
        public PokemonMove Move3 { get; set; }
        public PokemonMove Move4 { get; set; }
        public bool Shiny { get; set; }
        public string CreatedBy { get; set; }
    }
}