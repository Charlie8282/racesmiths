using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using racesmiths.Data;
using racesmiths.Models;

namespace racesmiths.Controllers
{
    public class ScoreboardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScoreboardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Scoreboards
        public async Task<IActionResult> Index()
        {
            return View(await _context.Scoreboard.ToListAsync());
        }

        // GET: Scoreboards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreboard = await _context.Scoreboard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scoreboard == null)
            {
                return NotFound();
            }

            return View(scoreboard);
        }

        // GET: Scoreboards/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ChampId,Points,Bonus,Revoke,RSUserId")] Scoreboard scoreboard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scoreboard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scoreboard);
        }

        // GET: Scoreboards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreboard = await _context.Scoreboard.FindAsync(id);
            if (scoreboard == null)
            {
                return NotFound();
            }
            return View(scoreboard);
        }

        // POST: Scoreboards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ChampId,Points,Bonus,Revoke,RSUserId")] Scoreboard scoreboard)
        {
            if (id != scoreboard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scoreboard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoreboardExists(scoreboard.Id))
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
            return View(scoreboard);
        }

        // GET: Scoreboards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreboard = await _context.Scoreboard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scoreboard == null)
            {
                return NotFound();
            }

            return View(scoreboard);
        }

        // POST: Scoreboards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scoreboard = await _context.Scoreboard.FindAsync(id);
            _context.Scoreboard.Remove(scoreboard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScoreboardExists(int id)
        {
            return _context.Scoreboard.Any(e => e.Id == id);
        }
    }
}
