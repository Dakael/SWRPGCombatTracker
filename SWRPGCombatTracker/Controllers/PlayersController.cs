using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWRPGCombatTracker.Models;

namespace SWRPGCombatTracker.Controllers
{
    public class PlayersController : Controller
    {
        private readonly CombatContext _context;

        public PlayersController(CombatContext context)
        {
            _context = context;
        }

        // GET: Players
        public async Task<IActionResult> Index()
        {
            return View(await _context.Players.ToListAsync());
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerModel = await _context.Players
                .FirstOrDefaultAsync(m => m.ID == id);
            if (playerModel == null)
            {
                return NotFound();
            }

            return View(playerModel);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Agility,Brawn,Career,CharacterName,CriticalInjuries,Cunning,CurrentStrain,CurrentWounds,CurrentXP,Encumberance,ID,Intellect,MaxEncumberance,MeleeDefense,Morality,Presence,RangedDefense,SoakValue,Species,StrainThreshold,TotalXP,Willpower,WoundThreshold")] PlayerModel playerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(playerModel);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerModel = await _context.Players.FindAsync(id);
            if (playerModel == null)
            {
                return NotFound();
            }
            return View(playerModel);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Agility,Brawn,Career,CharacterName,CriticalInjuries,Cunning,CurrentStrain,CurrentWounds,CurrentXP,Encumberance,ID,Intellect,MaxEncumberance,MeleeDefense,Morality,Presence,RangedDefense,SoakValue,Species,StrainThreshold,TotalXP,Willpower,WoundThreshold")] PlayerModel playerModel)
        {
            if (id != playerModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerModelExists(playerModel.ID))
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
            return View(playerModel);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerModel = await _context.Players
                .FirstOrDefaultAsync(m => m.ID == id);
            if (playerModel == null)
            {
                return NotFound();
            }

            return View(playerModel);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playerModel = await _context.Players.FindAsync(id);
            _context.Players.Remove(playerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerModelExists(int id)
        {
            return _context.Players.Any(e => e.ID == id);
        }
    }
}
