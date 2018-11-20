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
                // Look for any movies.
                if (context.Pokemon.Any())
                {
                    return;   // DB has been seeded
                }

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
                  });
                context.SaveChanges();
            }
        }
    }
}