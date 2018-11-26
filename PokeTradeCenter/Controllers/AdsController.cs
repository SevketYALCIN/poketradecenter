using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokeTradeCenter.Areas.Identity.Data;
using PokeTradeCenter.Models;
using PokeTradeCenter.ViewModels.Ads;

namespace PokeTradeCenter.Controllers
{
    public class AdsController : Controller
    {
        private readonly PokeTradeCenterContext _context;
        private readonly UserManager<PokeTradeCenterUser> _userManager;

        public AdsController(PokeTradeCenterContext context, UserManager<PokeTradeCenterUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Ads
        public IActionResult Index(int? pokemonId, string pokemonNature)
        {
            var ads = _context.Ad.AsQueryable();
            if (!String.IsNullOrEmpty(pokemonNature) && _context.PokemonNature.Any(x => x.Name == pokemonNature))
            {
                ads = ads.Where(x => x.Nature.Name == pokemonNature);
            }

            if (pokemonId != null && _context.Pokemon.Any(x => x.OrderNumber == pokemonId))
            {
                ads = ads.Where(x => x.Pokemon.OrderNumber == pokemonId);
            }

            ads = ads.OrderBy(x => x.ReleaseDate);

            var adsList = ads.Select(x => new AdListItem()
            {
                Atk = x.Atk,
                Def = x.Def,
                Hp = x.Hp,
                Level = x.Level,
                Move1 = x.Move1.Name,
                Move2 = x.Move2.Name,
                Move3 = x.Move3.Name,
                Move4 = x.Move4.Name,
                Nature = x.Nature.Name,
                Pokemon = x.Pokemon.Name,
                ReleaseDate = x.ReleaseDate,
                Shiny = x.Shiny,
                SpeAtk = x.SpeAtk,
                SpeDef = x.SpeDef,
                Speed = x.Speed,
                ID = x.ID
            }).ToList();

            var adsVM = new AdListingViewModel()
            {
                Ads = adsList,
                Pokemons = _context.Pokemon.OrderBy(x => x.OrderNumber).Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.OrderNumber.ToString()
                }).ToList(),
                Natures = _context.PokemonNature.OrderBy(x => x.Name).Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Name
                }).ToList()
            };

            return View(adsVM);
        }

        // GET: Ads/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ad = _context.Ad
                .Include(el => el.Pokemon)
                .Include(el => el.Nature)
                .Include(el => el.Move1)
                .Include(el => el.Move2)
                .Include(el => el.Move3)
                .Include(el => el.Move4)
                .FirstOrDefault(m => m.ID == id);

            if (ad == null)
            {
                return NotFound();
            }

            return View(new AdDetailsViewModel()
            {
                Atk = ad.Atk,
                Def = ad.Def,
                SpeDef = ad.SpeDef,
                SpeAtk = ad.SpeAtk,
                Hp = ad.Hp,
                Level = ad.Level,
                Move1 = ad.Move1.Name,
                Move2 = ad.Move2.Name,
                Move3 = ad.Move3.Name,
                Move4 = ad.Move4.Name,
                Nature = ad.Nature.Name,
                Pokemon = ad.Pokemon.Name,
                ReleaseDate = ad.ReleaseDate,
                Shiny = ad.Shiny,
                Speed = ad.Speed,
                ID = ad.ID
            });
        }

        // GET: Ads/Create
        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new AdCreationViewModel()
            {
                PokemonMoves = _context.PokemonMove.OrderBy(x => x.Name).Select(x => new SelectListItem(x.Name, x.ID.ToString())).ToList(),
                PokemonNatures = _context.PokemonNature.OrderBy(x => x.Name).Select(x => new SelectListItem(x.Name, x.ID.ToString())).ToList(),
                Pokemons = _context.Pokemon.OrderBy(x => x.OrderNumber).Select(x => new SelectListItem(x.Name, x.ID.ToString())).ToList()
            };
            return View(viewModel);
        }

        // POST: Ads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdCreationViewModel adVM)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (ModelState.IsValid)
            {
                var ad = new Ad()
                {
                    Atk = adVM.Atk,
                    Def = adVM.Def,
                    SpeDef = adVM.SpeDef,
                    SpeAtk = adVM.SpeAtk,
                    Hp = adVM.Hp,
                    Level = adVM.Level,
                    Move1 = _context.PokemonMove.First(x => x.ID == adVM.Move1),
                    Move2 = _context.PokemonMove.First(x => x.ID == adVM.Move2),
                    Move3 = _context.PokemonMove.First(x => x.ID == adVM.Move3),
                    Move4 = _context.PokemonMove.First(x => x.ID == adVM.Move4),
                    Nature = _context.PokemonNature.First(x => x.ID == adVM.PokemonNature),
                    Pokemon = _context.Pokemon.First(x => x.ID == adVM.PokemonId),
                    ReleaseDate = DateTime.Now,
                    Shiny = adVM.Shiny,
                    Speed = adVM.Speed,
                    CreatedBy = user.Id
                };
                _context.Add(ad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adVM);
        }

        // GET: Ads/Edit/5
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ad = _context.Ad
                .Include(el => el.Pokemon)
                .Include(el => el.Nature)
                .Include(el => el.Move1)
                .Include(el => el.Move2)
                .Include(el => el.Move3)
                .Include(el => el.Move4)
                .SingleOrDefault(m => m.ID == id);

            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId != ad.CreatedBy)
            {
                return RedirectToAction(nameof(Index));
            }


            if (ad == null)
            {
                return NotFound();
            }
            return View(new AdEditViewModel()
            {
                Atk = ad.Atk,
                Def = ad.Def,
                SpeDef = ad.SpeDef,
                SpeAtk = ad.SpeAtk,
                Hp = ad.Hp,
                Level = ad.Level,
                Move1 = ad.Move1.ID,
                Move2 = ad.Move2.ID,
                Move3 = ad.Move3.ID,
                Move4 = ad.Move4.ID,
                PokemonNature = ad.Nature.ID,
                PokemonId = ad.Pokemon.ID,
                Shiny = ad.Shiny,
                Speed = ad.Speed,
                ID = ad.ID,
                PokemonMoves = _context.PokemonMove.OrderBy(x => x.Name).Select(x => new SelectListItem(x.Name, x.ID.ToString())).ToList(),
                PokemonNatures = _context.PokemonNature.OrderBy(x => x.Name).Select(x => new SelectListItem(x.Name, x.ID.ToString())).ToList(),
                Pokemons = _context.Pokemon.OrderBy(x => x.OrderNumber).Select(x => new SelectListItem(x.Name, x.ID.ToString())).ToList()
            });
        }

        // POST: Ads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AdEditViewModel ad)
        {
            if (id != ad.ID)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId != _context.Ad.SingleOrDefault(x => x.ID == id).CreatedBy)
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldEntry = _context.Ad.FirstOrDefault(x => x.ID == id);
                    _context.Update(new Ad()
                    {
                        Atk = ad.Atk,
                        Def = ad.Def,
                        SpeDef = ad.SpeDef,
                        SpeAtk = ad.SpeAtk,
                        Hp = ad.Hp,
                        Level = ad.Level,
                        Move1 = _context.PokemonMove.First(x => x.ID == ad.Move1),
                        Move2 = _context.PokemonMove.First(x => x.ID == ad.Move2),
                        Move3 = _context.PokemonMove.First(x => x.ID == ad.Move3),
                        Move4 = _context.PokemonMove.First(x => x.ID == ad.Move4),
                        Nature = _context.PokemonNature.First(x => x.ID == ad.PokemonNature),
                        Pokemon = _context.Pokemon.First(x => x.ID == ad.PokemonId),
                        Shiny = ad.Shiny,
                        Speed = ad.Speed,
                        ID = ad.ID,
                        CreatedBy = oldEntry.CreatedBy,
                        ReleaseDate = oldEntry.ReleaseDate
                    });
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdExists(ad.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ad);
        }

        // GET: Ads/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId != _context.Ad.SingleOrDefault(x => x.ID == id).CreatedBy)
            {
                return RedirectToAction(nameof(Index));
            }

            var ad = await _context.Ad
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ad == null)
            {
                return NotFound();
            }

            return View(ad);
        }

        // POST: Ads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId != _context.Ad.SingleOrDefault(x => x.ID == id).CreatedBy)
            {
                return RedirectToAction(nameof(Index));
            }

            var ad = await _context.Ad.FindAsync(id);
            _context.Ad.Remove(ad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdExists(int id)
        {
            return _context.Ad.Any(e => e.ID == id);
        }
    }
}
