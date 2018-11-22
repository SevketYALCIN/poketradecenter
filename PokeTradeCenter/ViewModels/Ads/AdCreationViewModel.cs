using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeTradeCenter.ViewModels.Ads
{
    public class AdCreationViewModel
    {
        public List<SelectListItem> Pokemons { get; set; }
        public List<SelectListItem> PokemonNatures { get; set; }
        public List<SelectListItem> PokemonMoves { get; set; }
        public int PokemonId { get; set; }
        public int PokemonNature { get; set; }
        public int Atk { get; set; }
        public int SpeAtk { get; set; }
        public int Def { get; set; }
        public int SpeDef { get; set; }
        public int Speed { get; set; }
        public int Hp { get; set; }
        public int Level { get; set; }
        public int Move1 { get; set; }
        public int Move2 { get; set; }
        public int Move3 { get; set; }
        public int Move4 { get; set; }
        public bool Shiny { get; set; }
    }
}
