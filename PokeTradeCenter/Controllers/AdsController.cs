using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokeTradeCenter.Models;
using PokeTradeCenter.ViewModels.Ads;

namespace PokeTradeCenter.Controllers
{
    public class AdsController : Controller
    {
        private readonly PokeTradeCenterContext _context;

        public AdsController(PokeTradeCenterContext context)
        {
            _context = context;
        }

        // GET: Ads
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ad.ToListAsync());
        }

        // GET: Ads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ad = await _context.Ad
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ad == null)
            {
                return NotFound();
            }

            return View(ad);
        }

        // GET: Ads/Create
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdCreationViewModel adVM)
        {
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
                    Speed = adVM.Speed
                };
                _context.Add(ad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adVM);
        }

        // GET: Ads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ad = await _context.Ad.FindAsync(id);
            if (ad == null)
            {
                return NotFound();
            }
            return View(ad);
        }

        // POST: Ads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ReleaseDate,Atk,SpeAtk,Def,SpeDef,Speed,Hp,Level,Shiny")] Ad ad)
        {
            if (id != ad.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ad);
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
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
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
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
