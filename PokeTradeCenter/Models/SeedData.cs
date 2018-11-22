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
                          Name = "bulbasaur",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 2,
                          Name = "ivysaur",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 3,

                          Name = "venusaur",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 4,

                          Name = "charmander",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 5,

                          Name = "charmeleon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 6,

                          Name = "charizard",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 7,

                          Name = "squirtle",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 8,

                          Name = "wartortle",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 9,

                          Name = "blastoise",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 10,

                          Name = "caterpie",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 11,

                          Name = "metapod",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 12,

                          Name = "butterfree",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 13,

                          Name = "weedle",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 14,

                          Name = "kakuna",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 15,

                          Name = "beedrill",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 16,

                          Name = "pidgey",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 17,

                          Name = "pidgeotto",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 18,

                          Name = "pidgeot",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 19,

                          Name = "rattata",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 20,

                          Name = "raticate",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 21,

                          Name = "spearow",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 22,

                          Name = "fearow",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 23,

                          Name = "ekans",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 24,

                          Name = "arbok",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 25,

                          Name = "pikachu",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 26,

                          Name = "raichu",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 27,

                          Name = "sandshrew",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 28,

                          Name = "sandslash",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 29,

                          Name = "nidoran-f",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 30,

                          Name = "nidorina",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 31,

                          Name = "nidoqueen",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 32,

                          Name = "nidoran-m",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 33,

                          Name = "nidorino",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 34,

                          Name = "nidoking",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 35,

                          Name = "clefairy",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 36,

                          Name = "clefable",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 37,

                          Name = "vulpix",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 38,

                          Name = "ninetales",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 39,

                          Name = "jigglypuff",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 40,

                          Name = "wigglytuff",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 41,

                          Name = "zubat",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 42,

                          Name = "golbat",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 43,

                          Name = "oddish",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 44,

                          Name = "gloom",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 45,

                          Name = "vileplume",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 46,

                          Name = "paras",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 47,

                          Name = "parasect",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 48,

                          Name = "venonat",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 49,

                          Name = "venomoth",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 50,

                          Name = "diglett",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 51,

                          Name = "dugtrio",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 52,

                          Name = "meowth",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 53,

                          Name = "persian",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 54,

                          Name = "psyduck",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 55,

                          Name = "golduck",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 56,

                          Name = "mankey",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 57,

                          Name = "primeape",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 58,

                          Name = "growlithe",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 59,

                          Name = "arcanine",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 60,

                          Name = "poliwag",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 61,

                          Name = "poliwhirl",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 62,

                          Name = "poliwrath",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 63,

                          Name = "abra",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 64,

                          Name = "kadabra",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 65,

                          Name = "alakazam",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 66,

                          Name = "machop",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 67,

                          Name = "machoke",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 68,

                          Name = "machamp",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 69,

                          Name = "bellsprout",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 70,

                          Name = "weepinbell",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 71,

                          Name = "victreebel",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 72,

                          Name = "tentacool",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 73,

                          Name = "tentacruel",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 74,

                          Name = "geodude",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 75,

                          Name = "graveler",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 76,

                          Name = "golem",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 77,

                          Name = "ponyta",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 78,

                          Name = "rapidash",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 79,

                          Name = "slowpoke",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 80,

                          Name = "slowbro",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 81,

                          Name = "magnemite",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 82,

                          Name = "magneton",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 83,

                          Name = "farfetchd",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 84,

                          Name = "doduo",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 85,

                          Name = "dodrio",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 86,

                          Name = "seel",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 87,

                          Name = "dewgong",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 88,

                          Name = "grimer",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 89,

                          Name = "muk",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 90,

                          Name = "shellder",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 91,

                          Name = "cloyster",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 92,

                          Name = "gastly",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 93,

                          Name = "haunter",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 94,

                          Name = "gengar",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 95,

                          Name = "onix",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 96,

                          Name = "drowzee",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 97,

                          Name = "hypno",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 98,

                          Name = "krabby",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 99,

                          Name = "kingler",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 100,

                          Name = "voltorb",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 101,

                          Name = "electrode",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 102,

                          Name = "exeggcute",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 103,

                          Name = "exeggutor",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 104,

                          Name = "cubone",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 105,

                          Name = "marowak",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 106,

                          Name = "hitmonlee",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 107,

                          Name = "hitmonchan",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 108,

                          Name = "lickitung",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 109,

                          Name = "koffing",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 110,

                          Name = "weezing",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 111,

                          Name = "rhyhorn",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 112,

                          Name = "rhydon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 113,

                          Name = "chansey",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 114,

                          Name = "tangela",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 115,

                          Name = "kangaskhan",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 116,

                          Name = "horsea",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 117,

                          Name = "seadra",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 118,

                          Name = "goldeen",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 119,

                          Name = "seaking",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 120,

                          Name = "staryu",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 121,

                          Name = "starmie",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 122,

                          Name = "mr-mime",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 123,

                          Name = "scyther",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 124,

                          Name = "jynx",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 125,

                          Name = "electabuzz",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 126,

                          Name = "magmar",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 127,

                          Name = "pinsir",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 128,

                          Name = "tauros",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 129,

                          Name = "magikarp",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 130,

                          Name = "gyarados",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 131,

                          Name = "lapras",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 132,

                          Name = "ditto",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 133,

                          Name = "eevee",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 134,

                          Name = "vaporeon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 135,

                          Name = "jolteon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 136,

                          Name = "flareon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 137,

                          Name = "porygon",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 138,

                          Name = "omanyte",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 139,

                          Name = "omastar",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 140,

                          Name = "kabuto",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 141,

                          Name = "kabutops",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 142,

                          Name = "aerodactyl",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 143,

                          Name = "snorlax",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 144,

                          Name = "articuno",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 145,

                          Name = "zapdos",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 146,

                          Name = "moltres",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 147,

                          Name = "dratini",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 148,

                          Name = "dragonair",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 149,

                          Name = "dragonite",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 150,

                          Name = "mewtwo",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 151,
                          Name = "mew",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 808,
                          Name = "meltan",
                          Generation = 1
                      },
                      new Pokemon
                      {
                          OrderNumber = 809,
                          Name = "melmetal",
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
                    new PokemonMove { Name = "pound" },
                    new PokemonMove { Name = "karate-chop" },
                    new PokemonMove { Name = "double-slap" },
                    new PokemonMove { Name = "comet-punch" },
                    new PokemonMove { Name = "mega-punch" },
                    new PokemonMove { Name = "pay-day" },
                    new PokemonMove { Name = "fire-punch" },
                    new PokemonMove { Name = "ice-punch" },
                    new PokemonMove { Name = "thunder-punch" },
                    new PokemonMove { Name = "scratch" },
                    new PokemonMove { Name = "vice-grip" },
                    new PokemonMove { Name = "guillotine" },
                    new PokemonMove { Name = "razor-wind" },
                    new PokemonMove { Name = "swords-dance" },
                    new PokemonMove { Name = "cut" },
                    new PokemonMove { Name = "gust" },
                    new PokemonMove { Name = "wing-attack" },
                    new PokemonMove { Name = "whirlwind" },
                    new PokemonMove { Name = "fly" },
                    new PokemonMove { Name = "bind" },
                    new PokemonMove { Name = "slam" },
                    new PokemonMove { Name = "vine-whip" },
                    new PokemonMove { Name = "stomp" },
                    new PokemonMove { Name = "double-kick" },
                    new PokemonMove { Name = "mega-kick" },
                    new PokemonMove { Name = "jump-kick" },
                    new PokemonMove { Name = "rolling-kick" },
                    new PokemonMove { Name = "sand-attack" },
                    new PokemonMove { Name = "headbutt" },
                    new PokemonMove { Name = "horn-attack" },
                    new PokemonMove { Name = "fury-attack" },
                    new PokemonMove { Name = "horn-drill" },
                    new PokemonMove { Name = "tackle" },
                    new PokemonMove { Name = "body-slam" },
                    new PokemonMove { Name = "wrap" },
                    new PokemonMove { Name = "take-down" },
                    new PokemonMove { Name = "thrash" },
                    new PokemonMove { Name = "double-edge" },
                    new PokemonMove { Name = "tail-whip" },
                    new PokemonMove { Name = "poison-sting" },
                    new PokemonMove { Name = "twineedle" },
                    new PokemonMove { Name = "pin-missile" },
                    new PokemonMove { Name = "leer" },
                    new PokemonMove { Name = "bite" },
                    new PokemonMove { Name = "growl" },
                    new PokemonMove { Name = "roar" },
                    new PokemonMove { Name = "sing" },
                    new PokemonMove { Name = "supersonic" },
                    new PokemonMove { Name = "sonic-boom" },
                    new PokemonMove { Name = "disable" },
                    new PokemonMove { Name = "acid" },
                    new PokemonMove { Name = "ember" },
                    new PokemonMove { Name = "flamethrower" },
                    new PokemonMove { Name = "mist" },
                    new PokemonMove { Name = "water-gun" },
                    new PokemonMove { Name = "hydro-pump" },
                    new PokemonMove { Name = "surf" },
                    new PokemonMove { Name = "ice-beam" },
                    new PokemonMove { Name = "blizzard" },
                    new PokemonMove { Name = "psybeam" },
                    new PokemonMove { Name = "bubble-beam" },
                    new PokemonMove { Name = "aurora-beam" },
                    new PokemonMove { Name = "hyper-beam" },
                    new PokemonMove { Name = "peck" },
                    new PokemonMove { Name = "drill-peck" },
                    new PokemonMove { Name = "submission" },
                    new PokemonMove { Name = "low-kick" },
                    new PokemonMove { Name = "counter" },
                    new PokemonMove { Name = "seismic-toss" },
                    new PokemonMove { Name = "strength" },
                    new PokemonMove { Name = "absorb" },
                    new PokemonMove { Name = "mega-drain" },
                    new PokemonMove { Name = "leech-seed" },
                    new PokemonMove { Name = "growth" },
                    new PokemonMove { Name = "razor-leaf" },
                    new PokemonMove { Name = "solar-beam" },
                    new PokemonMove { Name = "poison-powder" },
                    new PokemonMove { Name = "stun-spore" },
                    new PokemonMove { Name = "sleep-powder" },
                    new PokemonMove { Name = "petal-dance" },
                    new PokemonMove { Name = "string-shot" },
                    new PokemonMove { Name = "dragon-rage" },
                    new PokemonMove { Name = "fire-spin" },
                    new PokemonMove { Name = "thunder-shock" },
                    new PokemonMove { Name = "thunderbolt" },
                    new PokemonMove { Name = "thunder-wave" },
                    new PokemonMove { Name = "thunder" },
                    new PokemonMove { Name = "rock-throw" },
                    new PokemonMove { Name = "earthquake" },
                    new PokemonMove { Name = "fissure" },
                    new PokemonMove { Name = "dig" },
                    new PokemonMove { Name = "toxic" },
                    new PokemonMove { Name = "confusion" },
                    new PokemonMove { Name = "psychic" },
                    new PokemonMove { Name = "hypnosis" },
                    new PokemonMove { Name = "meditate" },
                    new PokemonMove { Name = "agility" },
                    new PokemonMove { Name = "quick-attack" },
                    new PokemonMove { Name = "rage" },
                    new PokemonMove { Name = "teleport" },
                    new PokemonMove { Name = "night-shade" },
                    new PokemonMove { Name = "mimic" },
                    new PokemonMove { Name = "screech" },
                    new PokemonMove { Name = "double-team" },
                    new PokemonMove { Name = "recover" },
                    new PokemonMove { Name = "harden" },
                    new PokemonMove { Name = "minimize" },
                    new PokemonMove { Name = "smokescreen" },
                    new PokemonMove { Name = "confuse-ray" },
                    new PokemonMove { Name = "withdraw" },
                    new PokemonMove { Name = "defense-curl" },
                    new PokemonMove { Name = "barrier" },
                    new PokemonMove { Name = "light-screen" },
                    new PokemonMove { Name = "haze" },
                    new PokemonMove { Name = "reflect" },
                    new PokemonMove { Name = "focus-energy" },
                    new PokemonMove { Name = "bide" },
                    new PokemonMove { Name = "metronome" },
                    new PokemonMove { Name = "mirror-move" },
                    new PokemonMove { Name = "self-destruct" },
                    new PokemonMove { Name = "egg-bomb" },
                    new PokemonMove { Name = "lick" },
                    new PokemonMove { Name = "smog" },
                    new PokemonMove { Name = "sludge" },
                    new PokemonMove { Name = "bone-club" },
                    new PokemonMove { Name = "fire-blast" },
                    new PokemonMove { Name = "waterfall" },
                    new PokemonMove { Name = "clamp" },
                    new PokemonMove { Name = "swift" },
                    new PokemonMove { Name = "skull-bash" },
                    new PokemonMove { Name = "spike-cannon" },
                    new PokemonMove { Name = "constrict" },
                    new PokemonMove { Name = "amnesia" },
                    new PokemonMove { Name = "kinesis" },
                    new PokemonMove { Name = "soft-boiled" },
                    new PokemonMove { Name = "high-jump-kick" },
                    new PokemonMove { Name = "glare" },
                    new PokemonMove { Name = "dream-eater" },
                    new PokemonMove { Name = "poison-gas" },
                    new PokemonMove { Name = "barrage" },
                    new PokemonMove { Name = "leech-life" },
                    new PokemonMove { Name = "lovely-kiss" },
                    new PokemonMove { Name = "sky-attack" },
                    new PokemonMove { Name = "transform" },
                    new PokemonMove { Name = "bubble" },
                    new PokemonMove { Name = "dizzy-punch" },
                    new PokemonMove { Name = "spore" },
                    new PokemonMove { Name = "flash" },
                    new PokemonMove { Name = "psywave" },
                    new PokemonMove { Name = "splash" },
                    new PokemonMove { Name = "acid-armor" },
                    new PokemonMove { Name = "crabhammer" },
                    new PokemonMove { Name = "explosion" },
                    new PokemonMove { Name = "fury-swipes" },
                    new PokemonMove { Name = "bonemerang" },
                    new PokemonMove { Name = "rest" },
                    new PokemonMove { Name = "rock-slide" },
                    new PokemonMove { Name = "hyper-fang" },
                    new PokemonMove { Name = "sharpen" },
                    new PokemonMove { Name = "conversion" },
                    new PokemonMove { Name = "tri-attack" },
                    new PokemonMove { Name = "super-fang" },
                    new PokemonMove { Name = "slash" },
                    new PokemonMove { Name = "substitute" },
                    new PokemonMove { Name = "struggle" },
                    new PokemonMove { Name = "sketch" },
                    new PokemonMove { Name = "triple-kick" },
                    new PokemonMove { Name = "thief" },
                    new PokemonMove { Name = "spider-web" },
                    new PokemonMove { Name = "mind-reader" },
                    new PokemonMove { Name = "nightmare" },
                    new PokemonMove { Name = "flame-wheel" },
                    new PokemonMove { Name = "snore" },
                    new PokemonMove { Name = "curse" },
                    new PokemonMove { Name = "flail" },
                    new PokemonMove { Name = "conversion-2" },
                    new PokemonMove { Name = "aeroblast" },
                    new PokemonMove { Name = "cotton-spore" },
                    new PokemonMove { Name = "reversal" },
                    new PokemonMove { Name = "spite" },
                    new PokemonMove { Name = "powder-snow" },
                    new PokemonMove { Name = "protect" },
                    new PokemonMove { Name = "mach-punch" },
                    new PokemonMove { Name = "scary-face" },
                    new PokemonMove { Name = "feint-attack" },
                    new PokemonMove { Name = "sweet-kiss" },
                    new PokemonMove { Name = "belly-drum" },
                    new PokemonMove { Name = "sludge-bomb" },
                    new PokemonMove { Name = "mud-slap" },
                    new PokemonMove { Name = "octazooka" },
                    new PokemonMove { Name = "spikes" },
                    new PokemonMove { Name = "zap-cannon" },
                    new PokemonMove { Name = "foresight" },
                    new PokemonMove { Name = "destiny-bond" },
                    new PokemonMove { Name = "perish-song" },
                    new PokemonMove { Name = "icy-wind" },
                    new PokemonMove { Name = "detect" },
                    new PokemonMove { Name = "bone-rush" },
                    new PokemonMove { Name = "lock-on" },
                    new PokemonMove { Name = "outrage" },
                    new PokemonMove { Name = "sandstorm" },
                    new PokemonMove { Name = "giga-drain" },
                    new PokemonMove { Name = "endure" },
                    new PokemonMove { Name = "charm" },
                    new PokemonMove { Name = "rollout" },
                    new PokemonMove { Name = "false-swipe" },
                    new PokemonMove { Name = "swagger" },
                    new PokemonMove { Name = "milk-drink" },
                    new PokemonMove { Name = "spark" },
                    new PokemonMove { Name = "fury-cutter" },
                    new PokemonMove { Name = "steel-wing" },
                    new PokemonMove { Name = "mean-look" },
                    new PokemonMove { Name = "attract" },
                    new PokemonMove { Name = "sleep-talk" },
                    new PokemonMove { Name = "heal-bell" },
                    new PokemonMove { Name = "return" },
                    new PokemonMove { Name = "present" },
                    new PokemonMove { Name = "frustration" },
                    new PokemonMove { Name = "safeguard" },
                    new PokemonMove { Name = "pain-split" },
                    new PokemonMove { Name = "sacred-fire" },
                    new PokemonMove { Name = "magnitude" },
                    new PokemonMove { Name = "dynamic-punch" },
                    new PokemonMove { Name = "megahorn" },
                    new PokemonMove { Name = "dragon-breath" },
                    new PokemonMove { Name = "baton-pass" },
                    new PokemonMove { Name = "encore" },
                    new PokemonMove { Name = "pursuit" },
                    new PokemonMove { Name = "rapid-spin" },
                    new PokemonMove { Name = "sweet-scent" },
                    new PokemonMove { Name = "iron-tail" },
                    new PokemonMove { Name = "metal-claw" },
                    new PokemonMove { Name = "vital-throw" },
                    new PokemonMove { Name = "morning-sun" },
                    new PokemonMove { Name = "synthesis" },
                    new PokemonMove { Name = "moonlight" },
                    new PokemonMove { Name = "hidden-power" },
                    new PokemonMove { Name = "cross-chop" },
                    new PokemonMove { Name = "twister" },
                    new PokemonMove { Name = "rain-dance" },
                    new PokemonMove { Name = "sunny-day" },
                    new PokemonMove { Name = "crunch" },
                    new PokemonMove { Name = "mirror-coat" },
                    new PokemonMove { Name = "psych-up" },
                    new PokemonMove { Name = "extreme-speed" },
                    new PokemonMove { Name = "ancient-power" },
                    new PokemonMove { Name = "shadow-ball" },
                    new PokemonMove { Name = "future-sight" },
                    new PokemonMove { Name = "rock-smash" },
                    new PokemonMove { Name = "whirlpool" },
                    new PokemonMove { Name = "beat-up" },
                    new PokemonMove { Name = "fake-out" },
                    new PokemonMove { Name = "uproar" },
                    new PokemonMove { Name = "stockpile" },
                    new PokemonMove { Name = "spit-up" },
                    new PokemonMove { Name = "swallow" },
                    new PokemonMove { Name = "heat-wave" },
                    new PokemonMove { Name = "hail" },
                    new PokemonMove { Name = "torment" },
                    new PokemonMove { Name = "flatter" },
                    new PokemonMove { Name = "will-o-wisp" },
                    new PokemonMove { Name = "memento" },
                    new PokemonMove { Name = "facade" },
                    new PokemonMove { Name = "focus-punch" },
                    new PokemonMove { Name = "smelling-salts" },
                    new PokemonMove { Name = "follow-me" },
                    new PokemonMove { Name = "nature-power" },
                    new PokemonMove { Name = "charge" },
                    new PokemonMove { Name = "taunt" },
                    new PokemonMove { Name = "helping-hand" },
                    new PokemonMove { Name = "trick" },
                    new PokemonMove { Name = "role-play" },
                    new PokemonMove { Name = "wish" },
                    new PokemonMove { Name = "assist" },
                    new PokemonMove { Name = "ingrain" },
                    new PokemonMove { Name = "superpower" },
                    new PokemonMove { Name = "magic-coat" },
                    new PokemonMove { Name = "recycle" },
                    new PokemonMove { Name = "revenge" },
                    new PokemonMove { Name = "brick-break" },
                    new PokemonMove { Name = "yawn" },
                    new PokemonMove { Name = "knock-off" },
                    new PokemonMove { Name = "endeavor" },
                    new PokemonMove { Name = "eruption" },
                    new PokemonMove { Name = "skill-swap" },
                    new PokemonMove { Name = "imprison" },
                    new PokemonMove { Name = "refresh" },
                    new PokemonMove { Name = "grudge" },
                    new PokemonMove { Name = "snatch" },
                    new PokemonMove { Name = "secret-power" },
                    new PokemonMove { Name = "dive" },
                    new PokemonMove { Name = "arm-thrust" },
                    new PokemonMove { Name = "camouflage" },
                    new PokemonMove { Name = "tail-glow" },
                    new PokemonMove { Name = "luster-purge" },
                    new PokemonMove { Name = "mist-ball" },
                    new PokemonMove { Name = "feather-dance" },
                    new PokemonMove { Name = "teeter-dance" },
                    new PokemonMove { Name = "blaze-kick" },
                    new PokemonMove { Name = "mud-sport" },
                    new PokemonMove { Name = "ice-ball" },
                    new PokemonMove { Name = "needle-arm" },
                    new PokemonMove { Name = "slack-off" },
                    new PokemonMove { Name = "hyper-voice" },
                    new PokemonMove { Name = "poison-fang" },
                    new PokemonMove { Name = "crush-claw" },
                    new PokemonMove { Name = "blast-burn" },
                    new PokemonMove { Name = "hydro-cannon" },
                    new PokemonMove { Name = "meteor-mash" },
                    new PokemonMove { Name = "astonish" },
                    new PokemonMove { Name = "weather-ball" },
                    new PokemonMove { Name = "aromatherapy" },
                    new PokemonMove { Name = "fake-tears" },
                    new PokemonMove { Name = "air-cutter" },
                    new PokemonMove { Name = "overheat" },
                    new PokemonMove { Name = "odor-sleuth" },
                    new PokemonMove { Name = "rock-tomb" },
                    new PokemonMove { Name = "silver-wind" },
                    new PokemonMove { Name = "metal-sound" },
                    new PokemonMove { Name = "grass-whistle" },
                    new PokemonMove { Name = "tickle" },
                    new PokemonMove { Name = "cosmic-power" },
                    new PokemonMove { Name = "water-spout" },
                    new PokemonMove { Name = "signal-beam" },
                    new PokemonMove { Name = "shadow-punch" },
                    new PokemonMove { Name = "extrasensory" },
                    new PokemonMove { Name = "sky-uppercut" },
                    new PokemonMove { Name = "sand-tomb" },
                    new PokemonMove { Name = "sheer-cold" },
                    new PokemonMove { Name = "muddy-water" },
                    new PokemonMove { Name = "bullet-seed" },
                    new PokemonMove { Name = "aerial-ace" },
                    new PokemonMove { Name = "icicle-spear" },
                    new PokemonMove { Name = "iron-defense" },
                    new PokemonMove { Name = "block" },
                    new PokemonMove { Name = "howl" },
                    new PokemonMove { Name = "dragon-claw" },
                    new PokemonMove { Name = "frenzy-plant" },
                    new PokemonMove { Name = "bulk-up" },
                    new PokemonMove { Name = "bounce" },
                    new PokemonMove { Name = "mud-shot" },
                    new PokemonMove { Name = "poison-tail" },
                    new PokemonMove { Name = "covet" },
                    new PokemonMove { Name = "volt-tackle" },
                    new PokemonMove { Name = "magical-leaf" },
                    new PokemonMove { Name = "water-sport" },
                    new PokemonMove { Name = "calm-mind" },
                    new PokemonMove { Name = "leaf-blade" },
                    new PokemonMove { Name = "dragon-dance" },
                    new PokemonMove { Name = "rock-blast" },
                    new PokemonMove { Name = "shock-wave" },
                    new PokemonMove { Name = "water-pulse" },
                    new PokemonMove { Name = "doom-desire" },
                    new PokemonMove { Name = "psycho-boost" },
                    new PokemonMove { Name = "roost" },
                    new PokemonMove { Name = "gravity" },
                    new PokemonMove { Name = "miracle-eye" },
                    new PokemonMove { Name = "wake-up-slap" },
                    new PokemonMove { Name = "hammer-arm" },
                    new PokemonMove { Name = "gyro-ball" },
                    new PokemonMove { Name = "healing-wish" },
                    new PokemonMove { Name = "brine" },
                    new PokemonMove { Name = "natural-gift" },
                    new PokemonMove { Name = "feint" },
                    new PokemonMove { Name = "pluck" },
                    new PokemonMove { Name = "tailwind" },
                    new PokemonMove { Name = "acupressure" },
                    new PokemonMove { Name = "metal-burst" },
                    new PokemonMove { Name = "u-turn" },
                    new PokemonMove { Name = "close-combat" },
                    new PokemonMove { Name = "payback" },
                    new PokemonMove { Name = "assurance" },
                    new PokemonMove { Name = "embargo" },
                    new PokemonMove { Name = "fling" },
                    new PokemonMove { Name = "psycho-shift" },
                    new PokemonMove { Name = "trump-card" },
                    new PokemonMove { Name = "heal-block" },
                    new PokemonMove { Name = "wring-out" },
                    new PokemonMove { Name = "power-trick" },
                    new PokemonMove { Name = "gastro-acid" },
                    new PokemonMove { Name = "lucky-chant" },
                    new PokemonMove { Name = "me-first" },
                    new PokemonMove { Name = "copycat" },
                    new PokemonMove { Name = "power-swap" },
                    new PokemonMove { Name = "guard-swap" },
                    new PokemonMove { Name = "punishment" },
                    new PokemonMove { Name = "last-resort" },
                    new PokemonMove { Name = "worry-seed" },
                    new PokemonMove { Name = "sucker-punch" },
                    new PokemonMove { Name = "toxic-spikes" },
                    new PokemonMove { Name = "heart-swap" },
                    new PokemonMove { Name = "aqua-ring" },
                    new PokemonMove { Name = "magnet-rise" },
                    new PokemonMove { Name = "flare-blitz" },
                    new PokemonMove { Name = "force-palm" },
                    new PokemonMove { Name = "aura-sphere" },
                    new PokemonMove { Name = "rock-polish" },
                    new PokemonMove { Name = "poison-jab" },
                    new PokemonMove { Name = "dark-pulse" },
                    new PokemonMove { Name = "night-slash" },
                    new PokemonMove { Name = "aqua-tail" },
                    new PokemonMove { Name = "seed-bomb" },
                    new PokemonMove { Name = "air-slash" },
                    new PokemonMove { Name = "x-scissor" },
                    new PokemonMove { Name = "bug-buzz" },
                    new PokemonMove { Name = "dragon-pulse" },
                    new PokemonMove { Name = "dragon-rush" },
                    new PokemonMove { Name = "power-gem" },
                    new PokemonMove { Name = "drain-punch" },
                    new PokemonMove { Name = "vacuum-wave" },
                    new PokemonMove { Name = "focus-blast" },
                    new PokemonMove { Name = "energy-ball" },
                    new PokemonMove { Name = "brave-bird" },
                    new PokemonMove { Name = "earth-power" },
                    new PokemonMove { Name = "switcheroo" },
                    new PokemonMove { Name = "giga-impact" },
                    new PokemonMove { Name = "nasty-plot" },
                    new PokemonMove { Name = "bullet-punch" },
                    new PokemonMove { Name = "avalanche" },
                    new PokemonMove { Name = "ice-shard" },
                    new PokemonMove { Name = "shadow-claw" },
                    new PokemonMove { Name = "thunder-fang" },
                    new PokemonMove { Name = "ice-fang" },
                    new PokemonMove { Name = "fire-fang" },
                    new PokemonMove { Name = "shadow-sneak" },
                    new PokemonMove { Name = "mud-bomb" },
                    new PokemonMove { Name = "psycho-cut" },
                    new PokemonMove { Name = "zen-headbutt" },
                    new PokemonMove { Name = "mirror-shot" },
                    new PokemonMove { Name = "flash-cannon" },
                    new PokemonMove { Name = "rock-climb" },
                    new PokemonMove { Name = "defog" },
                    new PokemonMove { Name = "trick-room" },
                    new PokemonMove { Name = "draco-meteor" },
                    new PokemonMove { Name = "discharge" },
                    new PokemonMove { Name = "lava-plume" },
                    new PokemonMove { Name = "leaf-storm" },
                    new PokemonMove { Name = "power-whip" },
                    new PokemonMove { Name = "rock-wrecker" },
                    new PokemonMove { Name = "cross-poison" },
                    new PokemonMove { Name = "gunk-shot" },
                    new PokemonMove { Name = "iron-head" },
                    new PokemonMove { Name = "magnet-bomb" },
                    new PokemonMove { Name = "stone-edge" },
                    new PokemonMove { Name = "captivate" },
                    new PokemonMove { Name = "stealth-rock" },
                    new PokemonMove { Name = "grass-knot" },
                    new PokemonMove { Name = "chatter" },
                    new PokemonMove { Name = "judgment" },
                    new PokemonMove { Name = "bug-bite" },
                    new PokemonMove { Name = "charge-beam" },
                    new PokemonMove { Name = "wood-hammer" },
                    new PokemonMove { Name = "aqua-jet" },
                    new PokemonMove { Name = "attack-order" },
                    new PokemonMove { Name = "defend-order" },
                    new PokemonMove { Name = "heal-order" },
                    new PokemonMove { Name = "head-smash" },
                    new PokemonMove { Name = "double-hit" },
                    new PokemonMove { Name = "roar-of-time" },
                    new PokemonMove { Name = "spacial-rend" },
                    new PokemonMove { Name = "lunar-dance" },
                    new PokemonMove { Name = "crush-grip" },
                    new PokemonMove { Name = "magma-storm" },
                    new PokemonMove { Name = "dark-void" },
                    new PokemonMove { Name = "seed-flare" },
                    new PokemonMove { Name = "ominous-wind" },
                    new PokemonMove { Name = "shadow-force" },
                    new PokemonMove { Name = "hone-claws" },
                    new PokemonMove { Name = "wide-guard" },
                    new PokemonMove { Name = "guard-split" },
                    new PokemonMove { Name = "power-split" },
                    new PokemonMove { Name = "wonder-room" },
                    new PokemonMove { Name = "psyshock" },
                    new PokemonMove { Name = "venoshock" },
                    new PokemonMove { Name = "autotomize" },
                    new PokemonMove { Name = "rage-powder" },
                    new PokemonMove { Name = "telekinesis" },
                    new PokemonMove { Name = "magic-room" },
                    new PokemonMove { Name = "smack-down" },
                    new PokemonMove { Name = "storm-throw" },
                    new PokemonMove { Name = "flame-burst" },
                    new PokemonMove { Name = "sludge-wave" },
                    new PokemonMove { Name = "quiver-dance" },
                    new PokemonMove { Name = "heavy-slam" },
                    new PokemonMove { Name = "synchronoise" },
                    new PokemonMove { Name = "electro-ball" },
                    new PokemonMove { Name = "soak" },
                    new PokemonMove { Name = "flame-charge" },
                    new PokemonMove { Name = "coil" },
                    new PokemonMove { Name = "low-sweep" },
                    new PokemonMove { Name = "acid-spray" },
                    new PokemonMove { Name = "foul-play" },
                    new PokemonMove { Name = "simple-beam" },
                    new PokemonMove { Name = "entrainment" },
                    new PokemonMove { Name = "after-you" },
                    new PokemonMove { Name = "round" },
                    new PokemonMove { Name = "echoed-voice" },
                    new PokemonMove { Name = "chip-away" },
                    new PokemonMove { Name = "clear-smog" },
                    new PokemonMove { Name = "stored-power" },
                    new PokemonMove { Name = "quick-guard" },
                    new PokemonMove { Name = "ally-switch" },
                    new PokemonMove { Name = "scald" },
                    new PokemonMove { Name = "shell-smash" },
                    new PokemonMove { Name = "heal-pulse" },
                    new PokemonMove { Name = "hex" },
                    new PokemonMove { Name = "sky-drop" },
                    new PokemonMove { Name = "shift-gear" },
                    new PokemonMove { Name = "circle-throw" },
                    new PokemonMove { Name = "incinerate" },
                    new PokemonMove { Name = "quash" },
                    new PokemonMove { Name = "acrobatics" },
                    new PokemonMove { Name = "reflect-type" },
                    new PokemonMove { Name = "retaliate" },
                    new PokemonMove { Name = "final-gambit" },
                    new PokemonMove { Name = "bestow" },
                    new PokemonMove { Name = "inferno" },
                    new PokemonMove { Name = "water-pledge" },
                    new PokemonMove { Name = "fire-pledge" },
                    new PokemonMove { Name = "grass-pledge" },
                    new PokemonMove { Name = "volt-switch" },
                    new PokemonMove { Name = "struggle-bug" },
                    new PokemonMove { Name = "bulldoze" },
                    new PokemonMove { Name = "frost-breath" },
                    new PokemonMove { Name = "dragon-tail" },
                    new PokemonMove { Name = "work-up" },
                    new PokemonMove { Name = "electroweb" },
                    new PokemonMove { Name = "wild-charge" },
                    new PokemonMove { Name = "drill-run" },
                    new PokemonMove { Name = "dual-chop" },
                    new PokemonMove { Name = "heart-stamp" },
                    new PokemonMove { Name = "horn-leech" },
                    new PokemonMove { Name = "sacred-sword" },
                    new PokemonMove { Name = "razor-shell" },
                    new PokemonMove { Name = "heat-crash" },
                    new PokemonMove { Name = "leaf-tornado" },
                    new PokemonMove { Name = "steamroller" },
                    new PokemonMove { Name = "cotton-guard" },
                    new PokemonMove { Name = "night-daze" },
                    new PokemonMove { Name = "psystrike" },
                    new PokemonMove { Name = "tail-slap" },
                    new PokemonMove { Name = "hurricane" },
                    new PokemonMove { Name = "head-charge" },
                    new PokemonMove { Name = "gear-grind" },
                    new PokemonMove { Name = "searing-shot" },
                    new PokemonMove { Name = "techno-blast" },
                    new PokemonMove { Name = "relic-song" },
                    new PokemonMove { Name = "secret-sword" },
                    new PokemonMove { Name = "glaciate" },
                    new PokemonMove { Name = "bolt-strike" },
                    new PokemonMove { Name = "blue-flare" },
                    new PokemonMove { Name = "fiery-dance" },
                    new PokemonMove { Name = "freeze-shock" },
                    new PokemonMove { Name = "ice-burn" },
                    new PokemonMove { Name = "snarl" },
                    new PokemonMove { Name = "icicle-crash" },
                    new PokemonMove { Name = "v-create" },
                    new PokemonMove { Name = "fusion-flare" },
                    new PokemonMove { Name = "fusion-bolt" },
                    new PokemonMove { Name = "flying-press" },
                    new PokemonMove { Name = "mat-block" },
                    new PokemonMove { Name = "belch" },
                    new PokemonMove { Name = "rototiller" },
                    new PokemonMove { Name = "sticky-web" },
                    new PokemonMove { Name = "fell-stinger" },
                    new PokemonMove { Name = "phantom-force" },
                    new PokemonMove { Name = "trick-or-treat" },
                    new PokemonMove { Name = "noble-roar" },
                    new PokemonMove { Name = "ion-deluge" },
                    new PokemonMove { Name = "parabolic-charge" },
                    new PokemonMove { Name = "forests-curse" },
                    new PokemonMove { Name = "petal-blizzard" },
                    new PokemonMove { Name = "freeze-dry" },
                    new PokemonMove { Name = "disarming-voice" },
                    new PokemonMove { Name = "parting-shot" },
                    new PokemonMove { Name = "topsy-turvy" },
                    new PokemonMove { Name = "draining-kiss" },
                    new PokemonMove { Name = "crafty-shield" },
                    new PokemonMove { Name = "flower-shield" },
                    new PokemonMove { Name = "grassy-terrain" },
                    new PokemonMove { Name = "misty-terrain" },
                    new PokemonMove { Name = "electrify" },
                    new PokemonMove { Name = "play-rough" },
                    new PokemonMove { Name = "fairy-wind" },
                    new PokemonMove { Name = "moonblast" },
                    new PokemonMove { Name = "boomburst" },
                    new PokemonMove { Name = "fairy-lock" },
                    new PokemonMove { Name = "kings-shield" },
                    new PokemonMove { Name = "play-nice" },
                    new PokemonMove { Name = "confide" },
                    new PokemonMove { Name = "diamond-storm" },
                    new PokemonMove { Name = "steam-eruption" },
                    new PokemonMove { Name = "hyperspace-hole" },
                    new PokemonMove { Name = "water-shuriken" },
                    new PokemonMove { Name = "mystical-fire" },
                    new PokemonMove { Name = "spiky-shield" },
                    new PokemonMove { Name = "aromatic-mist" },
                    new PokemonMove { Name = "eerie-impulse" },
                    new PokemonMove { Name = "venom-drench" },
                    new PokemonMove { Name = "powder" },
                    new PokemonMove { Name = "geomancy" },
                    new PokemonMove { Name = "magnetic-flux" },
                    new PokemonMove { Name = "happy-hour" },
                    new PokemonMove { Name = "electric-terrain" },
                    new PokemonMove { Name = "dazzling-gleam" },
                    new PokemonMove { Name = "celebrate" },
                    new PokemonMove { Name = "hold-hands" },
                    new PokemonMove { Name = "baby-doll-eyes" },
                    new PokemonMove { Name = "nuzzle" },
                    new PokemonMove { Name = "hold-back" },
                    new PokemonMove { Name = "infestation" },
                    new PokemonMove { Name = "power-up-punch" },
                    new PokemonMove { Name = "oblivion-wing" },
                    new PokemonMove { Name = "thousand-arrows" },
                    new PokemonMove { Name = "thousand-waves" },
                    new PokemonMove { Name = "lands-wrath" },
                    new PokemonMove { Name = "light-of-ruin" },
                    new PokemonMove { Name = "origin-pulse" },
                    new PokemonMove { Name = "precipice-blades" },
                    new PokemonMove { Name = "dragon-ascent" },
                    new PokemonMove { Name = "hyperspace-fury" },
                    new PokemonMove { Name = "breakneck-blitz--physical" },
                    new PokemonMove { Name = "breakneck-blitz--special" },
                    new PokemonMove { Name = "all-out-pummeling--physical" },
                    new PokemonMove { Name = "all-out-pummeling--special" },
                    new PokemonMove { Name = "supersonic-skystrike--physical" },
                    new PokemonMove { Name = "supersonic-skystrike--special" },
                    new PokemonMove { Name = "acid-downpour--physical" },
                    new PokemonMove { Name = "acid-downpour--special" },
                    new PokemonMove { Name = "tectonic-rage--physical" },
                    new PokemonMove { Name = "tectonic-rage--special" },
                    new PokemonMove { Name = "continental-crush--physical" },
                    new PokemonMove { Name = "continental-crush--special" },
                    new PokemonMove { Name = "savage-spin-out--physical" },
                    new PokemonMove { Name = "savage-spin-out--special" },
                    new PokemonMove { Name = "never-ending-nightmare--physical" },
                    new PokemonMove { Name = "never-ending-nightmare--special" },
                    new PokemonMove { Name = "corkscrew-crash--physical" },
                    new PokemonMove { Name = "corkscrew-crash--special" },
                    new PokemonMove { Name = "inferno-overdrive--physical" },
                    new PokemonMove { Name = "inferno-overdrive--special" },
                    new PokemonMove { Name = "hydro-vortex--physical" },
                    new PokemonMove { Name = "hydro-vortex--special" },
                    new PokemonMove { Name = "bloom-doom--physical" },
                    new PokemonMove { Name = "bloom-doom--special" },
                    new PokemonMove { Name = "gigavolt-havoc--physical" },
                    new PokemonMove { Name = "gigavolt-havoc--special" },
                    new PokemonMove { Name = "shattered-psyche--physical" },
                    new PokemonMove { Name = "shattered-psyche--special" },
                    new PokemonMove { Name = "subzero-slammer--physical" },
                    new PokemonMove { Name = "subzero-slammer--special" },
                    new PokemonMove { Name = "devastating-drake--physical" },
                    new PokemonMove { Name = "devastating-drake--special" },
                    new PokemonMove { Name = "black-hole-eclipse--physical" },
                    new PokemonMove { Name = "black-hole-eclipse--special" },
                    new PokemonMove { Name = "twinkle-tackle--physical" },
                    new PokemonMove { Name = "twinkle-tackle--special" },
                    new PokemonMove { Name = "catastropika" },
                    new PokemonMove { Name = "shore-up" },
                    new PokemonMove { Name = "first-impression" },
                    new PokemonMove { Name = "baneful-bunker" },
                    new PokemonMove { Name = "spirit-shackle" },
                    new PokemonMove { Name = "darkest-lariat" },
                    new PokemonMove { Name = "sparkling-aria" },
                    new PokemonMove { Name = "ice-hammer" },
                    new PokemonMove { Name = "floral-healing" },
                    new PokemonMove { Name = "high-horsepower" },
                    new PokemonMove { Name = "strength-sap" },
                    new PokemonMove { Name = "solar-blade" },
                    new PokemonMove { Name = "leafage" },
                    new PokemonMove { Name = "spotlight" },
                    new PokemonMove { Name = "toxic-thread" },
                    new PokemonMove { Name = "laser-focus" },
                    new PokemonMove { Name = "gear-up" },
                    new PokemonMove { Name = "throat-chop" },
                    new PokemonMove { Name = "pollen-puff" },
                    new PokemonMove { Name = "anchor-shot" },
                    new PokemonMove { Name = "psychic-terrain" },
                    new PokemonMove { Name = "lunge" },
                    new PokemonMove { Name = "fire-lash" },
                    new PokemonMove { Name = "power-trip" },
                    new PokemonMove { Name = "burn-up" },
                    new PokemonMove { Name = "speed-swap" },
                    new PokemonMove { Name = "smart-strike" },
                    new PokemonMove { Name = "purify" },
                    new PokemonMove { Name = "revelation-dance" },
                    new PokemonMove { Name = "core-enforcer" },
                    new PokemonMove { Name = "trop-kick" },
                    new PokemonMove { Name = "instruct" },
                    new PokemonMove { Name = "beak-blast" },
                    new PokemonMove { Name = "clanging-scales" },
                    new PokemonMove { Name = "dragon-hammer" },
                    new PokemonMove { Name = "brutal-swing" },
                    new PokemonMove { Name = "aurora-veil" },
                    new PokemonMove { Name = "sinister-arrow-raid" },
                    new PokemonMove { Name = "malicious-moonsault" },
                    new PokemonMove { Name = "oceanic-operetta" },
                    new PokemonMove { Name = "guardian-of-alola" },
                    new PokemonMove { Name = "soul-stealing-7-star-strike" },
                    new PokemonMove { Name = "stoked-sparksurfer" },
                    new PokemonMove { Name = "pulverizing-pancake" },
                    new PokemonMove { Name = "extreme-evoboost" },
                    new PokemonMove { Name = "genesis-supernova" },
                    new PokemonMove { Name = "shell-trap" },
                    new PokemonMove { Name = "fleur-cannon" },
                    new PokemonMove { Name = "psychic-fangs" },
                    new PokemonMove { Name = "stomping-tantrum" },
                    new PokemonMove { Name = "shadow-bone" },
                    new PokemonMove { Name = "accelerock" },
                    new PokemonMove { Name = "liquidation" },
                    new PokemonMove { Name = "prismatic-laser" },
                    new PokemonMove { Name = "spectral-thief" },
                    new PokemonMove { Name = "sunsteel-strike" },
                    new PokemonMove { Name = "moongeist-beam" },
                    new PokemonMove { Name = "tearful-look" },
                    new PokemonMove { Name = "zing-zap" },
                    new PokemonMove { Name = "natures-madness" },
                    new PokemonMove { Name = "multi-attack" },
                    new PokemonMove { Name = "10-000-000-volt-thunderbolt" },
                    new PokemonMove { Name = "mind-blown" },
                    new PokemonMove { Name = "plasma-fists" },
                    new PokemonMove { Name = "photon-geyser" },
                    new PokemonMove { Name = "light-that-burns-the-sky" },
                    new PokemonMove { Name = "searing-sunraze-smash" },
                    new PokemonMove { Name = "menacing-moonraze-maelstrom" },
                    new PokemonMove { Name = "lets-snuggle-forever" },
                    new PokemonMove { Name = "splintered-stormshards" },
                    new PokemonMove { Name = "clangorous-soulblaze" },
                    new PokemonMove { Name = "shadow-rush" },
                    new PokemonMove { Name = "shadow-blast" },
                    new PokemonMove { Name = "shadow-blitz" },
                    new PokemonMove { Name = "shadow-bolt" },
                    new PokemonMove { Name = "shadow-break" },
                    new PokemonMove { Name = "shadow-chill" },
                    new PokemonMove { Name = "shadow-end" },
                    new PokemonMove { Name = "shadow-fire" },
                    new PokemonMove { Name = "shadow-rave" },
                    new PokemonMove { Name = "shadow-storm" },
                    new PokemonMove { Name = "shadow-wave" },
                    new PokemonMove { Name = "shadow-down" },
                    new PokemonMove { Name = "shadow-half" },
                    new PokemonMove { Name = "shadow-hold" },
                    new PokemonMove { Name = "shadow-mist" },
                    new PokemonMove { Name = "shadow-panic" },
                    new PokemonMove { Name = "shadow-shed" },
                    new PokemonMove { Name = "shadow-sky" },
                    new PokemonMove { Name = "double-iron-bash" },
                    new PokemonMove { Name = "pika-papow" },
                    new PokemonMove { Name = "veevee-volley" },
                    new PokemonMove { Name = "zippy-zap" },
                    new PokemonMove { Name = "splishy-splash" },
                    new PokemonMove { Name = "floaty-fall" },
                    new PokemonMove { Name = "bouncy-bubble" },
                    new PokemonMove { Name = "buzzy-buzz" },
                    new PokemonMove { Name = "sizzly-slide" },
                    new PokemonMove { Name = "glitzy-glow" },
                    new PokemonMove { Name = "baddy-bad" },
                    new PokemonMove { Name = "sappy-seed" },
                    new PokemonMove { Name = "freezy-frost" },
                    new PokemonMove { Name = "sparkly-swirl" });

                    #endregion
                }
                context.SaveChanges();
            }
        }
    }
}