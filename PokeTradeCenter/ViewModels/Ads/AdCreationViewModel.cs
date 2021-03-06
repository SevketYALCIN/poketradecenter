﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeTradeCenter.ViewModels.Ads
{
    public class AdCreationViewModel
    {
        public List<SelectListItem> Pokemons { get; set; }
        public List<SelectListItem> PokemonNatures { get; set; }
        public List<SelectListItem> PokemonMoves { get; set; }

        [Display(Name = "Pokemon")]
        public int PokemonId { get; set; }
        [Display(Name = "Nature")]
        public int PokemonNature { get; set; }
        [Display(Name = "Attack")]
        public int Atk { get; set; }
        [Display(Name = "Special Attack")]
        public int SpeAtk { get; set; }
        [Display(Name = "Defense")]
        public int Def { get; set; }
        [Display(Name = "Special Defense")]
        public int SpeDef { get; set; }
        [Display(Name = "Speed")]
        public int Speed { get; set; }
        [Display(Name = "HP")]
        public int Hp { get; set; }
        [Display(Name = "Level")]
        public int Level { get; set; }
        [Display(Name = "Move #1")]
        public int Move1 { get; set; }
        [Display(Name = "Move #2")]
        public int Move2 { get; set; }
        [Display(Name = "Move #3")]
        public int Move3 { get; set; }
        [Display(Name = "Move #4")]
        public int Move4 { get; set; }
        [Display(Name = "Shiny")]
        public bool Shiny { get; set; }
    }
}
