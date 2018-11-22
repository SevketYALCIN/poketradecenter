using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PokeTradeCenter.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PokeTradeCenterContext(
                serviceProvider.GetRequiredService<DbContextOptions<PokeTradeCenterContext>>()))
            {
                if (!context.Pokemon.Any())
                {
                    #region Pokemons
                    context.Pokemon.AddRange(
                      new Pokemon
                      {
                          OrderNumber = 1,
                          Name = "Bulbasaur",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 2,
                          Name = "Ivysaur",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 3,

                          Name = "Venusaur",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 4,

                          Name = "Charmander",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 5,

                          Name = "Charmeleon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 6,

                          Name = "Charizard",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 7,

                          Name = "Squirtle",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 8,

                          Name = "Wartortle",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 9,

                          Name = "Blastoise",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 10,

                          Name = "Caterpie",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 11,

                          Name = "Metapod",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 12,

                          Name = "Butterfree",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 13,

                          Name = "Weedle",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 14,

                          Name = "Kakuna",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 15,

                          Name = "Beedrill",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 16,

                          Name = "Pidgey",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 17,

                          Name = "Pidgeotto",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 18,

                          Name = "Pidgeot",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 19,

                          Name = "Rattata",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 20,

                          Name = "Raticate",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 21,

                          Name = "Spearow",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 22,

                          Name = "Fearow",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 23,

                          Name = "Ekans",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 24,

                          Name = "Arbok",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 25,

                          Name = "Pikachu",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 26,

                          Name = "Raichu",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 27,

                          Name = "Sandshrew",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 28,

                          Name = "Sandslash",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 29,

                          Name = "Nidoran-f",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 30,

                          Name = "Nidorina",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 31,

                          Name = "Nidoqueen",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 32,

                          Name = "Nidoran-m",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 33,

                          Name = "Nidorino",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 34,

                          Name = "Nidoking",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 35,

                          Name = "Clefairy",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 36,

                          Name = "Clefable",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 37,

                          Name = "Vulpix",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 38,

                          Name = "Ninetales",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 39,

                          Name = "Jigglypuff",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 40,

                          Name = "Wigglytuff",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 41,

                          Name = "Zubat",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 42,

                          Name = "Golbat",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 43,

                          Name = "Oddish",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 44,

                          Name = "Gloom",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 45,

                          Name = "Vileplume",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 46,

                          Name = "Paras",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 47,

                          Name = "Parasect",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 48,

                          Name = "Venonat",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 49,

                          Name = "Venomoth",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 50,

                          Name = "Diglett",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 51,

                          Name = "Dugtrio",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 52,

                          Name = "Meowth",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 53,

                          Name = "Persian",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 54,

                          Name = "Psyduck",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 55,

                          Name = "Golduck",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 56,

                          Name = "Mankey",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 57,

                          Name = "Primeape",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 58,

                          Name = "Growlithe",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 59,

                          Name = "Arcanine",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 60,

                          Name = "Poliwag",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 61,

                          Name = "Poliwhirl",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 62,

                          Name = "Poliwrath",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 63,

                          Name = "Abra",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 64,

                          Name = "Kadabra",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 65,

                          Name = "Alakazam",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 66,

                          Name = "Machop",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 67,

                          Name = "Machoke",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 68,

                          Name = "Machamp",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 69,

                          Name = "Bellsprout",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 70,

                          Name = "Weepinbell",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 71,

                          Name = "Victreebel",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 72,

                          Name = "Tentacool",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 73,

                          Name = "Tentacruel",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 74,

                          Name = "Geodude",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 75,

                          Name = "Graveler",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 76,

                          Name = "Golem",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 77,

                          Name = "Ponyta",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 78,

                          Name = "Rapidash",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 79,

                          Name = "Slowpoke",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 80,

                          Name = "Slowbro",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 81,

                          Name = "Magnemite",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 82,

                          Name = "Magneton",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 83,

                          Name = "Farfetchd",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 84,

                          Name = "Doduo",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 85,

                          Name = "Dodrio",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 86,

                          Name = "Seel",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 87,

                          Name = "Dewgong",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 88,

                          Name = "Grimer",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 89,

                          Name = "Muk",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 90,

                          Name = "Shellder",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 91,

                          Name = "Cloyster",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 92,

                          Name = "Gastly",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 93,

                          Name = "Haunter",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 94,

                          Name = "Gengar",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 95,

                          Name = "Onix",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 96,

                          Name = "Drowzee",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 97,

                          Name = "Hypno",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 98,

                          Name = "Krabby",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 99,

                          Name = "Kingler",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 100,

                          Name = "Voltorb",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 101,

                          Name = "Electrode",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 102,

                          Name = "Exeggcute",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 103,

                          Name = "Exeggutor",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 104,

                          Name = "Cubone",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 105,

                          Name = "Marowak",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 106,

                          Name = "Hitmonlee",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 107,

                          Name = "Hitmonchan",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 108,

                          Name = "Lickitung",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 109,

                          Name = "Koffing",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 110,

                          Name = "Weezing",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 111,

                          Name = "Rhyhorn",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 112,

                          Name = "Rhydon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 113,

                          Name = "Chansey",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 114,

                          Name = "Tangela",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 115,

                          Name = "Kangaskhan",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 116,

                          Name = "Horsea",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 117,

                          Name = "Seadra",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 118,

                          Name = "Goldeen",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 119,

                          Name = "Seaking",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 120,

                          Name = "Staryu",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 121,

                          Name = "Starmie",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 122,

                          Name = "Mr-mime",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 123,

                          Name = "Scyther",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 124,

                          Name = "Jynx",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 125,

                          Name = "Electabuzz",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 126,

                          Name = "Magmar",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 127,

                          Name = "Pinsir",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 128,

                          Name = "Tauros",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 129,

                          Name = "Magikarp",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 130,

                          Name = "Gyarados",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 131,

                          Name = "Lapras",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 132,

                          Name = "Ditto",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 133,

                          Name = "Eevee",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 134,

                          Name = "Vaporeon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 135,

                          Name = "Jolteon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 136,

                          Name = "Flareon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 137,

                          Name = "Porygon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 138,

                          Name = "Omanyte",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 139,

                          Name = "Omastar",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 140,

                          Name = "Kabuto",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 141,

                          Name = "Kabutops",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 142,

                          Name = "Aerodactyl",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 143,

                          Name = "Snorlax",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 144,

                          Name = "Articuno",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 145,

                          Name = "Zapdos",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 146,

                          Name = "Moltres",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 147,

                          Name = "Dratini",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 148,

                          Name = "Dragonair",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 149,

                          Name = "Dragonite",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 150,

                          Name = "Mewtwo",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 151,
                          Name = "Mew",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 808,
                          Name = "Meltan",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 809,
                          Name = "Melmetal",
                          Generation = 1
                      });
                    #endregion Pokemons
                }

                if (!context.PokemonNature.Any())
                {
                    #region Natures
                    context.PokemonNature.AddRange(
                  new PokemonNature
                  {
                      Name = "Hardy"
                  },
                  new PokemonNature
                  {
                      Name = "Lonely"
                  },
                  new PokemonNature
                  {
                      Name = "Brave"
                  },
                  new PokemonNature
                  {
                      Name = "Adamant"
                  },
                  new PokemonNature
                  {
                      Name = "Naughty"
                  },
                  new PokemonNature
                  {
                      Name = "Bold"
                  },
                  new PokemonNature
                  {
                      Name = "Docile"
                  },
                  new PokemonNature
                  {
                      Name = "Relaxed"
                  },
                  new PokemonNature
                  {
                      Name = "Impish"
                  },
                  new PokemonNature
                  {
                      Name = "Lax"
                  },
                  new PokemonNature
                  {
                      Name = "Timid"
                  },
                  new PokemonNature
                  {
                      Name = "Hasty"
                  },
                  new PokemonNature
                  {
                      Name = "Serious"
                  },
                  new PokemonNature
                  {
                      Name = "Jolly"
                  },
                  new PokemonNature
                  {
                      Name = "Naive"
                  },
                  new PokemonNature
                  {
                      Name = "Modest"
                  },
                  new PokemonNature
                  {
                      Name = "Mild"
                  },
                  new PokemonNature
                  {
                      Name = "Quiet"
                  },
                  new PokemonNature
                  {
                      Name = "Bashful"
                  },
                  new PokemonNature
                  {
                      Name = "Rash"
                  },
                  new PokemonNature
                  {
                      Name = "Calm"
                  },
                  new PokemonNature
                  {
                      Name = "Gentle"
                  },
                  new PokemonNature
                  {
                      Name = "Sassy"
                  },
                  new PokemonNature
                  {
                      Name = "Careful"
                  },
                  new PokemonNature
                  {
                      Name = "Quirky"
                  }
                );
                    #endregion Natures
                }

                if (!context.PokemonMove.Any())
                {
                    #region Moves
                    context.PokemonMove.AddRange(
                    new PokemonMove { Name = "Pound" },
                    new PokemonMove { Name = "Karate Chop" },
                    new PokemonMove { Name = "Double Slap" },
                    new PokemonMove { Name = "Comet Punch" },
                    new PokemonMove { Name = "Mega Punch" },
                    new PokemonMove { Name = "Pay Day" },
                    new PokemonMove { Name = "Fire Punch" },
                    new PokemonMove { Name = "Ice Punch" },
                    new PokemonMove { Name = "Thunder Punch" },
                    new PokemonMove { Name = "Scratch" },
                    new PokemonMove { Name = "Vice Grip" },
                    new PokemonMove { Name = "Guillotine" },
                    new PokemonMove { Name = "Razor Wind" },
                    new PokemonMove { Name = "Swords Dance" },
                    new PokemonMove { Name = "Cut" },
                    new PokemonMove { Name = "Gust" },
                    new PokemonMove { Name = "Wing Attack" },
                    new PokemonMove { Name = "Whirlwind" },
                    new PokemonMove { Name = "Fly" },
                    new PokemonMove { Name = "Bind" },
                    new PokemonMove { Name = "Slam" },
                    new PokemonMove { Name = "Vine Whip" },
                    new PokemonMove { Name = "Stomp" },
                    new PokemonMove { Name = "Double Kick" },
                    new PokemonMove { Name = "Mega Kick" },
                    new PokemonMove { Name = "Jump Kick" },
                    new PokemonMove { Name = "Rolling Kick" },
                    new PokemonMove { Name = "Sand Attack" },
                    new PokemonMove { Name = "Headbutt" },
                    new PokemonMove { Name = "Horn Attack" },
                    new PokemonMove { Name = "Fury Attack" },
                    new PokemonMove { Name = "Horn Drill" },
                    new PokemonMove { Name = "Tackle" },
                    new PokemonMove { Name = "Body Slam" },
                    new PokemonMove { Name = "Wrap" },
                    new PokemonMove { Name = "Take Down" },
                    new PokemonMove { Name = "Thrash" },
                    new PokemonMove { Name = "Double Edge" },
                    new PokemonMove { Name = "Tail Whip" },
                    new PokemonMove { Name = "Poison Sting" },
                    new PokemonMove { Name = "Twineedle" },
                    new PokemonMove { Name = "Pin Missile" },
                    new PokemonMove { Name = "Leer" },
                    new PokemonMove { Name = "Bite" },
                    new PokemonMove { Name = "Growl" },
                    new PokemonMove { Name = "Roar" },
                    new PokemonMove { Name = "Sing" },
                    new PokemonMove { Name = "Supersonic" },
                    new PokemonMove { Name = "Sonic Boom" },
                    new PokemonMove { Name = "Disable" },
                    new PokemonMove { Name = "Acid" },
                    new PokemonMove { Name = "Ember" },
                    new PokemonMove { Name = "Flamethrower" },
                    new PokemonMove { Name = "Mist" },
                    new PokemonMove { Name = "Water Gun" },
                    new PokemonMove { Name = "Hydro Pump" },
                    new PokemonMove { Name = "Surf" },
                    new PokemonMove { Name = "Ice Beam" },
                    new PokemonMove { Name = "Blizzard" },
                    new PokemonMove { Name = "Psybeam" },
                    new PokemonMove { Name = "Bubble Beam" },
                    new PokemonMove { Name = "Aurora Beam" },
                    new PokemonMove { Name = "Hyper Beam" },
                    new PokemonMove { Name = "Peck" },
                    new PokemonMove { Name = "Drill Peck" },
                    new PokemonMove { Name = "Submission" },
                    new PokemonMove { Name = "Low Kick" },
                    new PokemonMove { Name = "Counter" },
                    new PokemonMove { Name = "Seismic Toss" },
                    new PokemonMove { Name = "Strength" },
                    new PokemonMove { Name = "Absorb" },
                    new PokemonMove { Name = "Mega Drain" },
                    new PokemonMove { Name = "Leech Seed" },
                    new PokemonMove { Name = "Growth" },
                    new PokemonMove { Name = "Razor Leaf" },
                    new PokemonMove { Name = "Solar Beam" },
                    new PokemonMove { Name = "Poison Powder" },
                    new PokemonMove { Name = "Stun Spore" },
                    new PokemonMove { Name = "Sleep Powder" },
                    new PokemonMove { Name = "Petal Dance" },
                    new PokemonMove { Name = "String Shot" },
                    new PokemonMove { Name = "Dragon Rage" },
                    new PokemonMove { Name = "Fire Spin" },
                    new PokemonMove { Name = "Thunder Shock" },
                    new PokemonMove { Name = "Thunderbolt" },
                    new PokemonMove { Name = "Thunder Wave" },
                    new PokemonMove { Name = "Thunder" },
                    new PokemonMove { Name = "Rock Throw" },
                    new PokemonMove { Name = "Earthquake" },
                    new PokemonMove { Name = "Fissure" },
                    new PokemonMove { Name = "Dig" },
                    new PokemonMove { Name = "Toxic" },
                    new PokemonMove { Name = "Confusion" },
                    new PokemonMove { Name = "Psychic" },
                    new PokemonMove { Name = "Hypnosis" },
                    new PokemonMove { Name = "Meditate" },
                    new PokemonMove { Name = "Agility" },
                    new PokemonMove { Name = "Quick Attack" },
                    new PokemonMove { Name = "Rage" },
                    new PokemonMove { Name = "Teleport" },
                    new PokemonMove { Name = "Night Shade" },
                    new PokemonMove { Name = "Mimic" },
                    new PokemonMove { Name = "Screech" },
                    new PokemonMove { Name = "Double Team" },
                    new PokemonMove { Name = "Recover" },
                    new PokemonMove { Name = "Harden" },
                    new PokemonMove { Name = "Minimize" },
                    new PokemonMove { Name = "Smokescreen" },
                    new PokemonMove { Name = "Confuse Ray" },
                    new PokemonMove { Name = "Withdraw" },
                    new PokemonMove { Name = "Defense Curl" },
                    new PokemonMove { Name = "Barrier" },
                    new PokemonMove { Name = "Light Screen" },
                    new PokemonMove { Name = "Haze" },
                    new PokemonMove { Name = "Reflect" },
                    new PokemonMove { Name = "Focus Energy" },
                    new PokemonMove { Name = "Bide" },
                    new PokemonMove { Name = "Metronome" },
                    new PokemonMove { Name = "Mirror Move" },
                    new PokemonMove { Name = "Self Destruct" },
                    new PokemonMove { Name = "Egg Bomb" },
                    new PokemonMove { Name = "Lick" },
                    new PokemonMove { Name = "Smog" },
                    new PokemonMove { Name = "Sludge" },
                    new PokemonMove { Name = "Bone Club" },
                    new PokemonMove { Name = "Fire Blast" },
                    new PokemonMove { Name = "Waterfall" },
                    new PokemonMove { Name = "Clamp" },
                    new PokemonMove { Name = "Swift" },
                    new PokemonMove { Name = "Skull Bash" },
                    new PokemonMove { Name = "Spike Cannon" },
                    new PokemonMove { Name = "Constrict" },
                    new PokemonMove { Name = "Amnesia" },
                    new PokemonMove { Name = "Kinesis" },
                    new PokemonMove { Name = "Soft Boiled" },
                    new PokemonMove { Name = "High Jump Kick" },
                    new PokemonMove { Name = "Glare" },
                    new PokemonMove { Name = "Dream Eater" },
                    new PokemonMove { Name = "Poison Gas" },
                    new PokemonMove { Name = "Barrage" },
                    new PokemonMove { Name = "Leech Life" },
                    new PokemonMove { Name = "Lovely Kiss" },
                    new PokemonMove { Name = "Sky Attack" },
                    new PokemonMove { Name = "Transform" },
                    new PokemonMove { Name = "Bubble" },
                    new PokemonMove { Name = "Dizzy Punch" },
                    new PokemonMove { Name = "Spore" },
                    new PokemonMove { Name = "Flash" },
                    new PokemonMove { Name = "Psywave" },
                    new PokemonMove { Name = "Splash" },
                    new PokemonMove { Name = "Acid Armor" },
                    new PokemonMove { Name = "Crabhammer" },
                    new PokemonMove { Name = "Explosion" },
                    new PokemonMove { Name = "Fury Swipes" },
                    new PokemonMove { Name = "Bonemerang" },
                    new PokemonMove { Name = "Rest" },
                    new PokemonMove { Name = "Rock Slide" },
                    new PokemonMove { Name = "Hyper Fang" },
                    new PokemonMove { Name = "Sharpen" },
                    new PokemonMove { Name = "Conversion" },
                    new PokemonMove { Name = "Tri Attack" },
                    new PokemonMove { Name = "Super Fang" },
                    new PokemonMove { Name = "Slash" },
                    new PokemonMove { Name = "Substitute" },
                    new PokemonMove { Name = "Struggle" },
                    new PokemonMove { Name = "Sketch" },
                    new PokemonMove { Name = "Triple Kick" },
                    new PokemonMove { Name = "Thief" },
                    new PokemonMove { Name = "Spider Web" },
                    new PokemonMove { Name = "Mind Reader" },
                    new PokemonMove { Name = "Nightmare" },
                    new PokemonMove { Name = "Flame Wheel" },
                    new PokemonMove { Name = "Snore" },
                    new PokemonMove { Name = "Curse" },
                    new PokemonMove { Name = "Flail" },
                    new PokemonMove { Name = "Conversion 2" },
                    new PokemonMove { Name = "Aeroblast" },
                    new PokemonMove { Name = "Cotton Spore" },
                    new PokemonMove { Name = "Reversal" },
                    new PokemonMove { Name = "Spite" },
                    new PokemonMove { Name = "Powder Snow" },
                    new PokemonMove { Name = "Protect" },
                    new PokemonMove { Name = "Mach Punch" },
                    new PokemonMove { Name = "Scary Face" },
                    new PokemonMove { Name = "Feint Attack" },
                    new PokemonMove { Name = "Sweet Kiss" },
                    new PokemonMove { Name = "Belly Drum" },
                    new PokemonMove { Name = "Sludge Bomb" },
                    new PokemonMove { Name = "Mud Slap" },
                    new PokemonMove { Name = "Octazooka" },
                    new PokemonMove { Name = "Spikes" },
                    new PokemonMove { Name = "Zap Cannon" },
                    new PokemonMove { Name = "Foresight" },
                    new PokemonMove { Name = "Destiny Bond" },
                    new PokemonMove { Name = "Perish Song" },
                    new PokemonMove { Name = "Icy Wind" },
                    new PokemonMove { Name = "Detect" },
                    new PokemonMove { Name = "Bone Rush" },
                    new PokemonMove { Name = "Lock On" },
                    new PokemonMove { Name = "Outrage" },
                    new PokemonMove { Name = "Sandstorm" },
                    new PokemonMove { Name = "Giga Drain" },
                    new PokemonMove { Name = "Endure" },
                    new PokemonMove { Name = "Charm" },
                    new PokemonMove { Name = "Rollout" },
                    new PokemonMove { Name = "False Swipe" },
                    new PokemonMove { Name = "Swagger" },
                    new PokemonMove { Name = "Milk Drink" },
                    new PokemonMove { Name = "Spark" },
                    new PokemonMove { Name = "Fury Cutter" },
                    new PokemonMove { Name = "Steel Wing" },
                    new PokemonMove { Name = "Mean Look" },
                    new PokemonMove { Name = "Attract" },
                    new PokemonMove { Name = "Sleep Talk" },
                    new PokemonMove { Name = "Heal Bell" },
                    new PokemonMove { Name = "Return" },
                    new PokemonMove { Name = "Present" },
                    new PokemonMove { Name = "Frustration" },
                    new PokemonMove { Name = "Safeguard" },
                    new PokemonMove { Name = "Pain Split" },
                    new PokemonMove { Name = "Sacred Fire" },
                    new PokemonMove { Name = "Magnitude" },
                    new PokemonMove { Name = "Dynamic Punch" },
                    new PokemonMove { Name = "Megahorn" },
                    new PokemonMove { Name = "Dragon Breath" },
                    new PokemonMove { Name = "Baton Pass" },
                    new PokemonMove { Name = "Encore" },
                    new PokemonMove { Name = "Pursuit" },
                    new PokemonMove { Name = "Rapid Spin" },
                    new PokemonMove { Name = "Sweet Scent" },
                    new PokemonMove { Name = "Iron Tail" },
                    new PokemonMove { Name = "Metal Claw" },
                    new PokemonMove { Name = "Vital Throw" },
                    new PokemonMove { Name = "Morning Sun" },
                    new PokemonMove { Name = "Synthesis" },
                    new PokemonMove { Name = "Moonlight" },
                    new PokemonMove { Name = "Hidden Power" },
                    new PokemonMove { Name = "Cross Chop" },
                    new PokemonMove { Name = "Twister" },
                    new PokemonMove { Name = "Rain Dance" },
                    new PokemonMove { Name = "Sunny Day" },
                    new PokemonMove { Name = "Crunch" },
                    new PokemonMove { Name = "Mirror Coat" },
                    new PokemonMove { Name = "Psych Up" },
                    new PokemonMove { Name = "Extreme Speed" },
                    new PokemonMove { Name = "Ancient Power" },
                    new PokemonMove { Name = "Shadow Ball" },
                    new PokemonMove { Name = "Future Sight" },
                    new PokemonMove { Name = "Rock Smash" },
                    new PokemonMove { Name = "Whirlpool" },
                    new PokemonMove { Name = "Beat Up" },
                    new PokemonMove { Name = "Fake Out" },
                    new PokemonMove { Name = "Uproar" },
                    new PokemonMove { Name = "Stockpile" },
                    new PokemonMove { Name = "Spit Up" },
                    new PokemonMove { Name = "Swallow" },
                    new PokemonMove { Name = "Heat Wave" },
                    new PokemonMove { Name = "Hail" },
                    new PokemonMove { Name = "Torment" },
                    new PokemonMove { Name = "Flatter" },
                    new PokemonMove { Name = "Will O Wisp" },
                    new PokemonMove { Name = "Memento" },
                    new PokemonMove { Name = "Facade" },
                    new PokemonMove { Name = "Focus Punch" },
                    new PokemonMove { Name = "Smelling Salts" },
                    new PokemonMove { Name = "Follow Me" },
                    new PokemonMove { Name = "Nature Power" },
                    new PokemonMove { Name = "Charge" },
                    new PokemonMove { Name = "Taunt" },
                    new PokemonMove { Name = "Helping Hand" },
                    new PokemonMove { Name = "Trick" },
                    new PokemonMove { Name = "Role Play" },
                    new PokemonMove { Name = "Wish" },
                    new PokemonMove { Name = "Assist" },
                    new PokemonMove { Name = "Ingrain" },
                    new PokemonMove { Name = "Superpower" },
                    new PokemonMove { Name = "Magic Coat" },
                    new PokemonMove { Name = "Recycle" },
                    new PokemonMove { Name = "Revenge" },
                    new PokemonMove { Name = "Brick Break" },
                    new PokemonMove { Name = "Yawn" },
                    new PokemonMove { Name = "Knock Off" },
                    new PokemonMove { Name = "Endeavor" },
                    new PokemonMove { Name = "Eruption" },
                    new PokemonMove { Name = "Skill Swap" },
                    new PokemonMove { Name = "Imprison" },
                    new PokemonMove { Name = "Refresh" },
                    new PokemonMove { Name = "Grudge" },
                    new PokemonMove { Name = "Snatch" },
                    new PokemonMove { Name = "Secret Power" },
                    new PokemonMove { Name = "Dive" },
                    new PokemonMove { Name = "Arm Thrust" },
                    new PokemonMove { Name = "Camouflage" },
                    new PokemonMove { Name = "Tail Glow" },
                    new PokemonMove { Name = "Luster Purge" },
                    new PokemonMove { Name = "Mist Ball" },
                    new PokemonMove { Name = "Feather Dance" },
                    new PokemonMove { Name = "Teeter Dance" },
                    new PokemonMove { Name = "Blaze Kick" },
                    new PokemonMove { Name = "Mud Sport" },
                    new PokemonMove { Name = "Ice Ball" },
                    new PokemonMove { Name = "Needle Arm" },
                    new PokemonMove { Name = "Slack Off" },
                    new PokemonMove { Name = "Hyper Voice" },
                    new PokemonMove { Name = "Poison Fang" },
                    new PokemonMove { Name = "Crush Claw" },
                    new PokemonMove { Name = "Blast Burn" },
                    new PokemonMove { Name = "Hydro Cannon" },
                    new PokemonMove { Name = "Meteor Mash" },
                    new PokemonMove { Name = "Astonish" },
                    new PokemonMove { Name = "Weather Ball" },
                    new PokemonMove { Name = "Aromatherapy" },
                    new PokemonMove { Name = "Fake Tears" },
                    new PokemonMove { Name = "Air Cutter" },
                    new PokemonMove { Name = "Overheat" },
                    new PokemonMove { Name = "Odor Sleuth" },
                    new PokemonMove { Name = "Rock Tomb" },
                    new PokemonMove { Name = "Silver Wind" },
                    new PokemonMove { Name = "Metal Sound" },
                    new PokemonMove { Name = "Grass Whistle" },
                    new PokemonMove { Name = "Tickle" },
                    new PokemonMove { Name = "Cosmic Power" },
                    new PokemonMove { Name = "Water Spout" },
                    new PokemonMove { Name = "Signal Beam" },
                    new PokemonMove { Name = "Shadow Punch" },
                    new PokemonMove { Name = "Extrasensory" },
                    new PokemonMove { Name = "Sky Uppercut" },
                    new PokemonMove { Name = "Sand Tomb" },
                    new PokemonMove { Name = "Sheer Cold" },
                    new PokemonMove { Name = "Muddy Water" },
                    new PokemonMove { Name = "Bullet Seed" },
                    new PokemonMove { Name = "Aerial Ace" },
                    new PokemonMove { Name = "Icicle Spear" },
                    new PokemonMove { Name = "Iron Defense" },
                    new PokemonMove { Name = "Block" },
                    new PokemonMove { Name = "Howl" },
                    new PokemonMove { Name = "Dragon Claw" },
                    new PokemonMove { Name = "Frenzy Plant" },
                    new PokemonMove { Name = "Bulk Up" },
                    new PokemonMove { Name = "Bounce" },
                    new PokemonMove { Name = "Mud Shot" },
                    new PokemonMove { Name = "Poison Tail" },
                    new PokemonMove { Name = "Covet" },
                    new PokemonMove { Name = "Volt Tackle" },
                    new PokemonMove { Name = "Magical Leaf" },
                    new PokemonMove { Name = "Water Sport" },
                    new PokemonMove { Name = "Calm Mind" },
                    new PokemonMove { Name = "Leaf Blade" },
                    new PokemonMove { Name = "Dragon Dance" },
                    new PokemonMove { Name = "Rock Blast" },
                    new PokemonMove { Name = "Shock Wave" },
                    new PokemonMove { Name = "Water Pulse" },
                    new PokemonMove { Name = "Doom Desire" },
                    new PokemonMove { Name = "Psycho Boost" },
                    new PokemonMove { Name = "Roost" },
                    new PokemonMove { Name = "Gravity" },
                    new PokemonMove { Name = "Miracle Eye" },
                    new PokemonMove { Name = "Wake Up Slap" },
                    new PokemonMove { Name = "Hammer Arm" },
                    new PokemonMove { Name = "Gyro Ball" },
                    new PokemonMove { Name = "Healing Wish" },
                    new PokemonMove { Name = "Brine" },
                    new PokemonMove { Name = "Natural Gift" },
                    new PokemonMove { Name = "Feint" },
                    new PokemonMove { Name = "Pluck" },
                    new PokemonMove { Name = "Tailwind" },
                    new PokemonMove { Name = "Acupressure" },
                    new PokemonMove { Name = "Metal Burst" },
                    new PokemonMove { Name = "U Turn" },
                    new PokemonMove { Name = "Close Combat" },
                    new PokemonMove { Name = "Payback" },
                    new PokemonMove { Name = "Assurance" },
                    new PokemonMove { Name = "Embargo" },
                    new PokemonMove { Name = "Fling" },
                    new PokemonMove { Name = "Psycho Shift" },
                    new PokemonMove { Name = "Trump Card" },
                    new PokemonMove { Name = "Heal Block" },
                    new PokemonMove { Name = "Wring Out" },
                    new PokemonMove { Name = "Power Trick" },
                    new PokemonMove { Name = "Gastro Acid" },
                    new PokemonMove { Name = "Lucky Chant" },
                    new PokemonMove { Name = "Me First" },
                    new PokemonMove { Name = "Copycat" },
                    new PokemonMove { Name = "Power Swap" },
                    new PokemonMove { Name = "Guard Swap" },
                    new PokemonMove { Name = "Punishment" },
                    new PokemonMove { Name = "Last Resort" },
                    new PokemonMove { Name = "Worry Seed" },
                    new PokemonMove { Name = "Sucker Punch" },
                    new PokemonMove { Name = "Toxic Spikes" },
                    new PokemonMove { Name = "Heart Swap" },
                    new PokemonMove { Name = "Aqua Ring" },
                    new PokemonMove { Name = "Magnet Rise" },
                    new PokemonMove { Name = "Flare Blitz" },
                    new PokemonMove { Name = "Force Palm" },
                    new PokemonMove { Name = "Aura Sphere" },
                    new PokemonMove { Name = "Rock Polish" },
                    new PokemonMove { Name = "Poison Jab" },
                    new PokemonMove { Name = "Dark Pulse" },
                    new PokemonMove { Name = "Night Slash" },
                    new PokemonMove { Name = "Aqua Tail" },
                    new PokemonMove { Name = "Seed Bomb" },
                    new PokemonMove { Name = "Air Slash" },
                    new PokemonMove { Name = "X Scissor" },
                    new PokemonMove { Name = "Bug Buzz" },
                    new PokemonMove { Name = "Dragon Pulse" },
                    new PokemonMove { Name = "Dragon Rush" },
                    new PokemonMove { Name = "Power Gem" },
                    new PokemonMove { Name = "Drain Punch" },
                    new PokemonMove { Name = "Vacuum Wave" },
                    new PokemonMove { Name = "Focus Blast" },
                    new PokemonMove { Name = "Energy Ball" },
                    new PokemonMove { Name = "Brave Bird" },
                    new PokemonMove { Name = "Earth Power" },
                    new PokemonMove { Name = "Switcheroo" },
                    new PokemonMove { Name = "Giga Impact" },
                    new PokemonMove { Name = "Nasty Plot" },
                    new PokemonMove { Name = "Bullet Punch" },
                    new PokemonMove { Name = "Avalanche" },
                    new PokemonMove { Name = "Ice Shard" },
                    new PokemonMove { Name = "Shadow Claw" },
                    new PokemonMove { Name = "Thunder Fang" },
                    new PokemonMove { Name = "Ice Fang" },
                    new PokemonMove { Name = "Fire Fang" },
                    new PokemonMove { Name = "Shadow Sneak" },
                    new PokemonMove { Name = "Mud Bomb" },
                    new PokemonMove { Name = "Psycho Cut" },
                    new PokemonMove { Name = "Zen Headbutt" },
                    new PokemonMove { Name = "Mirror Shot" },
                    new PokemonMove { Name = "Flash Cannon" },
                    new PokemonMove { Name = "Rock Climb" },
                    new PokemonMove { Name = "Defog" },
                    new PokemonMove { Name = "Trick Room" },
                    new PokemonMove { Name = "Draco Meteor" },
                    new PokemonMove { Name = "Discharge" },
                    new PokemonMove { Name = "Lava Plume" },
                    new PokemonMove { Name = "Leaf Storm" },
                    new PokemonMove { Name = "Power Whip" },
                    new PokemonMove { Name = "Rock Wrecker" },
                    new PokemonMove { Name = "Cross Poison" },
                    new PokemonMove { Name = "Gunk Shot" },
                    new PokemonMove { Name = "Iron Head" },
                    new PokemonMove { Name = "Magnet Bomb" },
                    new PokemonMove { Name = "Stone Edge" },
                    new PokemonMove { Name = "Captivate" },
                    new PokemonMove { Name = "Stealth Rock" },
                    new PokemonMove { Name = "Grass Knot" },
                    new PokemonMove { Name = "Chatter" },
                    new PokemonMove { Name = "Judgment" },
                    new PokemonMove { Name = "Bug Bite" },
                    new PokemonMove { Name = "Charge Beam" },
                    new PokemonMove { Name = "Wood Hammer" },
                    new PokemonMove { Name = "Aqua Jet" },
                    new PokemonMove { Name = "Attack Order" },
                    new PokemonMove { Name = "Defend Order" },
                    new PokemonMove { Name = "Heal Order" },
                    new PokemonMove { Name = "Head Smash" },
                    new PokemonMove { Name = "Double Hit" },
                    new PokemonMove { Name = "Roar Of Time" },
                    new PokemonMove { Name = "Spacial Rend" },
                    new PokemonMove { Name = "Lunar Dance" },
                    new PokemonMove { Name = "Crush Grip" },
                    new PokemonMove { Name = "Magma Storm" },
                    new PokemonMove { Name = "Dark Void" },
                    new PokemonMove { Name = "Seed Flare" },
                    new PokemonMove { Name = "Ominous Wind" },
                    new PokemonMove { Name = "Shadow Force" },
                    new PokemonMove { Name = "Hone Claws" },
                    new PokemonMove { Name = "Wide Guard" },
                    new PokemonMove { Name = "Guard Split" },
                    new PokemonMove { Name = "Power Split" },
                    new PokemonMove { Name = "Wonder Room" },
                    new PokemonMove { Name = "Psyshock" },
                    new PokemonMove { Name = "Venoshock" },
                    new PokemonMove { Name = "Autotomize" },
                    new PokemonMove { Name = "Rage Powder" },
                    new PokemonMove { Name = "Telekinesis" },
                    new PokemonMove { Name = "Magic Room" },
                    new PokemonMove { Name = "Smack Down" },
                    new PokemonMove { Name = "Storm Throw" },
                    new PokemonMove { Name = "Flame Burst" },
                    new PokemonMove { Name = "Sludge Wave" },
                    new PokemonMove { Name = "Quiver Dance" },
                    new PokemonMove { Name = "Heavy Slam" },
                    new PokemonMove { Name = "Synchronoise" },
                    new PokemonMove { Name = "Electro Ball" },
                    new PokemonMove { Name = "Soak" },
                    new PokemonMove { Name = "Flame Charge" },
                    new PokemonMove { Name = "Coil" },
                    new PokemonMove { Name = "Low Sweep" },
                    new PokemonMove { Name = "Acid Spray" },
                    new PokemonMove { Name = "Foul Play" },
                    new PokemonMove { Name = "Simple Beam" },
                    new PokemonMove { Name = "Entrainment" },
                    new PokemonMove { Name = "After You" },
                    new PokemonMove { Name = "Round" },
                    new PokemonMove { Name = "Echoed Voice" },
                    new PokemonMove { Name = "Chip Away" },
                    new PokemonMove { Name = "Clear Smog" },
                    new PokemonMove { Name = "Stored Power" },
                    new PokemonMove { Name = "Quick Guard" },
                    new PokemonMove { Name = "Ally Switch" },
                    new PokemonMove { Name = "Scald" },
                    new PokemonMove { Name = "Shell Smash" },
                    new PokemonMove { Name = "Heal Pulse" },
                    new PokemonMove { Name = "Hex" },
                    new PokemonMove { Name = "Sky Drop" },
                    new PokemonMove { Name = "Shift Gear" },
                    new PokemonMove { Name = "Circle Throw" },
                    new PokemonMove { Name = "Incinerate" },
                    new PokemonMove { Name = "Quash" },
                    new PokemonMove { Name = "Acrobatics" },
                    new PokemonMove { Name = "Reflect Type" },
                    new PokemonMove { Name = "Retaliate" },
                    new PokemonMove { Name = "Final Gambit" },
                    new PokemonMove { Name = "Bestow" },
                    new PokemonMove { Name = "Inferno" },
                    new PokemonMove { Name = "Water Pledge" },
                    new PokemonMove { Name = "Fire Pledge" },
                    new PokemonMove { Name = "Grass Pledge" },
                    new PokemonMove { Name = "Volt Switch" },
                    new PokemonMove { Name = "Struggle Bug" },
                    new PokemonMove { Name = "Bulldoze" },
                    new PokemonMove { Name = "Frost Breath" },
                    new PokemonMove { Name = "Dragon Tail" },
                    new PokemonMove { Name = "Work Up" },
                    new PokemonMove { Name = "Electroweb" },
                    new PokemonMove { Name = "Wild Charge" },
                    new PokemonMove { Name = "Drill Run" },
                    new PokemonMove { Name = "Dual Chop" },
                    new PokemonMove { Name = "Heart Stamp" },
                    new PokemonMove { Name = "Horn Leech" },
                    new PokemonMove { Name = "Sacred Sword" },
                    new PokemonMove { Name = "Razor Shell" },
                    new PokemonMove { Name = "Heat Crash" },
                    new PokemonMove { Name = "Leaf Tornado" },
                    new PokemonMove { Name = "Steamroller" },
                    new PokemonMove { Name = "Cotton Guard" },
                    new PokemonMove { Name = "Night Daze" },
                    new PokemonMove { Name = "Psystrike" },
                    new PokemonMove { Name = "Tail Slap" },
                    new PokemonMove { Name = "Hurricane" },
                    new PokemonMove { Name = "Head Charge" },
                    new PokemonMove { Name = "Gear Grind" },
                    new PokemonMove { Name = "Searing Shot" },
                    new PokemonMove { Name = "Techno Blast" },
                    new PokemonMove { Name = "Relic Song" },
                    new PokemonMove { Name = "Secret Sword" },
                    new PokemonMove { Name = "Glaciate" },
                    new PokemonMove { Name = "Bolt Strike" },
                    new PokemonMove { Name = "Blue Flare" },
                    new PokemonMove { Name = "Fiery Dance" },
                    new PokemonMove { Name = "Freeze Shock" },
                    new PokemonMove { Name = "Ice Burn" },
                    new PokemonMove { Name = "Snarl" },
                    new PokemonMove { Name = "Icicle Crash" },
                    new PokemonMove { Name = "V Create" },
                    new PokemonMove { Name = "Fusion Flare" },
                    new PokemonMove { Name = "Fusion Bolt" },
                    new PokemonMove { Name = "Flying Press" },
                    new PokemonMove { Name = "Mat Block" },
                    new PokemonMove { Name = "Belch" },
                    new PokemonMove { Name = "Rototiller" },
                    new PokemonMove { Name = "Sticky Web" },
                    new PokemonMove { Name = "Fell Stinger" },
                    new PokemonMove { Name = "Phantom Force" },
                    new PokemonMove { Name = "Trick Or Treat" },
                    new PokemonMove { Name = "Noble Roar" },
                    new PokemonMove { Name = "Ion Deluge" },
                    new PokemonMove { Name = "Parabolic Charge" },
                    new PokemonMove { Name = "Forests Curse" },
                    new PokemonMove { Name = "Petal Blizzard" },
                    new PokemonMove { Name = "Freeze Dry" },
                    new PokemonMove { Name = "Disarming Voice" },
                    new PokemonMove { Name = "Parting Shot" },
                    new PokemonMove { Name = "Topsy Turvy" },
                    new PokemonMove { Name = "Draining Kiss" },
                    new PokemonMove { Name = "Crafty Shield" },
                    new PokemonMove { Name = "Flower Shield" },
                    new PokemonMove { Name = "Grassy Terrain" },
                    new PokemonMove { Name = "Misty Terrain" },
                    new PokemonMove { Name = "Electrify" },
                    new PokemonMove { Name = "Play Rough" },
                    new PokemonMove { Name = "Fairy Wind" },
                    new PokemonMove { Name = "Moonblast" },
                    new PokemonMove { Name = "Boomburst" },
                    new PokemonMove { Name = "Fairy Lock" },
                    new PokemonMove { Name = "Kings Shield" },
                    new PokemonMove { Name = "Play Nice" },
                    new PokemonMove { Name = "Confide" },
                    new PokemonMove { Name = "Diamond Storm" },
                    new PokemonMove { Name = "Steam Eruption" },
                    new PokemonMove { Name = "Hyperspace Hole" },
                    new PokemonMove { Name = "Water Shuriken" },
                    new PokemonMove { Name = "Mystical Fire" },
                    new PokemonMove { Name = "Spiky Shield" },
                    new PokemonMove { Name = "Aromatic Mist" },
                    new PokemonMove { Name = "Eerie Impulse" },
                    new PokemonMove { Name = "Venom Drench" },
                    new PokemonMove { Name = "Powder" },
                    new PokemonMove { Name = "Geomancy" },
                    new PokemonMove { Name = "Magnetic Flux" },
                    new PokemonMove { Name = "Happy Hour" },
                    new PokemonMove { Name = "Electric Terrain" },
                    new PokemonMove { Name = "Dazzling Gleam" },
                    new PokemonMove { Name = "Celebrate" },
                    new PokemonMove { Name = "Hold Hands" },
                    new PokemonMove { Name = "Baby Doll Eyes" },
                    new PokemonMove { Name = "Nuzzle" },
                    new PokemonMove { Name = "Hold Back" },
                    new PokemonMove { Name = "Infestation" },
                    new PokemonMove { Name = "Power Up Punch" },
                    new PokemonMove { Name = "Oblivion Wing" },
                    new PokemonMove { Name = "Thousand Arrows" },
                    new PokemonMove { Name = "Thousand Waves" },
                    new PokemonMove { Name = "Lands Wrath" },
                    new PokemonMove { Name = "Light Of Ruin" },
                    new PokemonMove { Name = "Origin Pulse" },
                    new PokemonMove { Name = "Precipice Blades" },
                    new PokemonMove { Name = "Dragon Ascent" },
                    new PokemonMove { Name = "Hyperspace Fury" },
                    new PokemonMove { Name = "Breakneck Blitz  Physical" },
                    new PokemonMove { Name = "Breakneck Blitz  Special" },
                    new PokemonMove { Name = "All Out Pummeling  Physical" },
                    new PokemonMove { Name = "All Out Pummeling  Special" },
                    new PokemonMove { Name = "Supersonic Skystrike  Physical" },
                    new PokemonMove { Name = "Supersonic Skystrike  Special" },
                    new PokemonMove { Name = "Acid Downpour  Physical" },
                    new PokemonMove { Name = "Acid Downpour  Special" },
                    new PokemonMove { Name = "Tectonic Rage  Physical" },
                    new PokemonMove { Name = "Tectonic Rage  Special" },
                    new PokemonMove { Name = "Continental Crush  Physical" },
                    new PokemonMove { Name = "Continental Crush  Special" },
                    new PokemonMove { Name = "Savage Spin Out  Physical" },
                    new PokemonMove { Name = "Savage Spin Out  Special" },
                    new PokemonMove { Name = "Never Ending Nightmare  Physical" },
                    new PokemonMove { Name = "Never Ending Nightmare  Special" },
                    new PokemonMove { Name = "Corkscrew Crash  Physical" },
                    new PokemonMove { Name = "Corkscrew Crash  Special" },
                    new PokemonMove { Name = "Inferno Overdrive  Physical" },
                    new PokemonMove { Name = "Inferno Overdrive  Special" },
                    new PokemonMove { Name = "Hydro Vortex  Physical" },
                    new PokemonMove { Name = "Hydro Vortex  Special" },
                    new PokemonMove { Name = "Bloom Doom  Physical" },
                    new PokemonMove { Name = "Bloom Doom  Special" },
                    new PokemonMove { Name = "Gigavolt Havoc  Physical" },
                    new PokemonMove { Name = "Gigavolt Havoc  Special" },
                    new PokemonMove { Name = "Shattered Psyche  Physical" },
                    new PokemonMove { Name = "Shattered Psyche  Special" },
                    new PokemonMove { Name = "Subzero Slammer  Physical" },
                    new PokemonMove { Name = "Subzero Slammer  Special" },
                    new PokemonMove { Name = "Devastating Drake  Physical" },
                    new PokemonMove { Name = "Devastating Drake  Special" },
                    new PokemonMove { Name = "Black Hole Eclipse  Physical" },
                    new PokemonMove { Name = "Black Hole Eclipse  Special" },
                    new PokemonMove { Name = "Twinkle Tackle  Physical" },
                    new PokemonMove { Name = "Twinkle Tackle  Special" },
                    new PokemonMove { Name = "Catastropika" },
                    new PokemonMove { Name = "Shore Up" },
                    new PokemonMove { Name = "First Impression" },
                    new PokemonMove { Name = "Baneful Bunker" },
                    new PokemonMove { Name = "Spirit Shackle" },
                    new PokemonMove { Name = "Darkest Lariat" },
                    new PokemonMove { Name = "Sparkling Aria" },
                    new PokemonMove { Name = "Ice Hammer" },
                    new PokemonMove { Name = "Floral Healing" },
                    new PokemonMove { Name = "High Horsepower" },
                    new PokemonMove { Name = "Strength Sap" },
                    new PokemonMove { Name = "Solar Blade" },
                    new PokemonMove { Name = "Leafage" },
                    new PokemonMove { Name = "Spotlight" },
                    new PokemonMove { Name = "Toxic Thread" },
                    new PokemonMove { Name = "Laser Focus" },
                    new PokemonMove { Name = "Gear Up" },
                    new PokemonMove { Name = "Throat Chop" },
                    new PokemonMove { Name = "Pollen Puff" },
                    new PokemonMove { Name = "Anchor Shot" },
                    new PokemonMove { Name = "Psychic Terrain" },
                    new PokemonMove { Name = "Lunge" },
                    new PokemonMove { Name = "Fire Lash" },
                    new PokemonMove { Name = "Power Trip" },
                    new PokemonMove { Name = "Burn Up" },
                    new PokemonMove { Name = "Speed Swap" },
                    new PokemonMove { Name = "Smart Strike" },
                    new PokemonMove { Name = "Purify" },
                    new PokemonMove { Name = "Revelation Dance" },
                    new PokemonMove { Name = "Core Enforcer" },
                    new PokemonMove { Name = "Trop Kick" },
                    new PokemonMove { Name = "Instruct" },
                    new PokemonMove { Name = "Beak Blast" },
                    new PokemonMove { Name = "Clanging Scales" },
                    new PokemonMove { Name = "Dragon Hammer" },
                    new PokemonMove { Name = "Brutal Swing" },
                    new PokemonMove { Name = "Aurora Veil" },
                    new PokemonMove { Name = "Sinister Arrow Raid" },
                    new PokemonMove { Name = "Malicious Moonsault" },
                    new PokemonMove { Name = "Oceanic Operetta" },
                    new PokemonMove { Name = "Guardian Of Alola" },
                    new PokemonMove { Name = "Soul Stealing 7 Star Strike" },
                    new PokemonMove { Name = "Stoked Sparksurfer" },
                    new PokemonMove { Name = "Pulverizing Pancake" },
                    new PokemonMove { Name = "Extreme Evoboost" },
                    new PokemonMove { Name = "Genesis Supernova" },
                    new PokemonMove { Name = "Shell Trap" },
                    new PokemonMove { Name = "Fleur Cannon" },
                    new PokemonMove { Name = "Psychic Fangs" },
                    new PokemonMove { Name = "Stomping Tantrum" },
                    new PokemonMove { Name = "Shadow Bone" },
                    new PokemonMove { Name = "Accelerock" },
                    new PokemonMove { Name = "Liquidation" },
                    new PokemonMove { Name = "Prismatic Laser" },
                    new PokemonMove { Name = "Spectral Thief" },
                    new PokemonMove { Name = "Sunsteel Strike" },
                    new PokemonMove { Name = "Moongeist Beam" },
                    new PokemonMove { Name = "Tearful Look" },
                    new PokemonMove { Name = "Zing Zap" },
                    new PokemonMove { Name = "Natures Madness" },
                    new PokemonMove { Name = "Multi Attack" },
                    new PokemonMove { Name = "10 000 000 Volt Thunderbolt" },
                    new PokemonMove { Name = "Mind Blown" },
                    new PokemonMove { Name = "Plasma Fists" },
                    new PokemonMove { Name = "Photon Geyser" },
                    new PokemonMove { Name = "Light That Burns The Sky" },
                    new PokemonMove { Name = "Searing Sunraze Smash" },
                    new PokemonMove { Name = "Menacing Moonraze Maelstrom" },
                    new PokemonMove { Name = "Lets Snuggle Forever" },
                    new PokemonMove { Name = "Splintered Stormshards" },
                    new PokemonMove { Name = "Clangorous Soulblaze" },
                    new PokemonMove { Name = "Shadow Rush" },
                    new PokemonMove { Name = "Shadow Blast" },
                    new PokemonMove { Name = "Shadow Blitz" },
                    new PokemonMove { Name = "Shadow Bolt" },
                    new PokemonMove { Name = "Shadow Break" },
                    new PokemonMove { Name = "Shadow Chill" },
                    new PokemonMove { Name = "Shadow End" },
                    new PokemonMove { Name = "Shadow Fire" },
                    new PokemonMove { Name = "Shadow Rave" },
                    new PokemonMove { Name = "Shadow Storm" },
                    new PokemonMove { Name = "Shadow Wave" },
                    new PokemonMove { Name = "Shadow Down" },
                    new PokemonMove { Name = "Shadow Half" },
                    new PokemonMove { Name = "Shadow Hold" },
                    new PokemonMove { Name = "Shadow Mist" },
                    new PokemonMove { Name = "Shadow Panic" },
                    new PokemonMove { Name = "Shadow Shed" },
                    new PokemonMove { Name = "Shadow Sky" },
                    new PokemonMove { Name = "Double Iron Bash" },
                    new PokemonMove { Name = "Pika Papow" },
                    new PokemonMove { Name = "Veevee Volley" },
                    new PokemonMove { Name = "Zippy Zap" },
                    new PokemonMove { Name = "Splishy Splash" },
                    new PokemonMove { Name = "Floaty Fall" },
                    new PokemonMove { Name = "Bouncy Bubble" },
                    new PokemonMove { Name = "Buzzy Buzz" },
                    new PokemonMove { Name = "Sizzly Slide" },
                    new PokemonMove { Name = "Glitzy Glow" },
                    new PokemonMove { Name = "Baddy Bad" },
                    new PokemonMove { Name = "Sappy Seed" },
                    new PokemonMove { Name = "Freezy Frost" },
                    new PokemonMove { Name = "Sparkly Swirl" });
                    #endregion
                }
                context.SaveChanges();
            }
        }
    }
}