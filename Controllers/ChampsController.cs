using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using racesmiths.Data;
using racesmiths.Models;

namespace racesmiths.Controllers
{
    public class ChampsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<RSUser> _userManager;

        public ChampsController(ApplicationDbContext context, UserManager<RSUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Champs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Champs.Include(c => c.Club);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Champs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var champ = await _context.Champs
                .Include(c => c.Club)
                .FirstOrDefaultAsync(m => m.Id == id);
            champ.Events = _context.Event
                .Where(e => e.ChampId == id)
                .ToList();
            if (champ == null)
            {
                return NotFound();
            }

            return View(champ);
        }

        // GET: Champs/Create
        public IActionResult Create(int? Id)
        {
            ViewData["ClubUserId"] = new SelectList(_context.Users, "Id", "Gamertag");
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "ClubName");
            return View();
        }

        // POST: Champs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClubId,ClubUserId,ChampName,Rounds,Rules,Description,Settings,Scheduled")] Champ champ)
        {
            if (ModelState.IsValid)
            {
                var clubId = await _userManager.GetUserAsync(User);
                _context.Add(champ);
                champ.ClubUserId = _userManager.GetUserId(User);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Champs", new { id = champ.Id });
            }
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "ClubName", champ.ClubId);
            return View(champ);
        }

        // GET: Champs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var champ = await _context.Champs.FindAsync(id);
            if (champ == null)
            {
                return NotFound();
            }
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "ClubName", champ.ClubId);
            return View(champ);
        }

        // POST: Champs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClubId,RSUserId,ClubUserId,ChampName,RaceCount,Rules,Description,Settings,ChampType,StartDate,Status,ImagePath,ImageData")] Champ champ)
        {
            if (id != champ.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(champ);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChampExists(champ.Id))
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
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "ClubName", champ.ClubId);
            return View(champ);
        }

        // GET: Champs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var champ = await _context.Champs
                .Include(c => c.Club)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (champ == null)
            {
                return NotFound();
            }

            return View(champ);
        }

        // POST: Champs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var champ = await _context.Champs.FindAsync(id);
            _context.Champs.Remove(champ);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChampExists(int id)
        {
            return _context.Champs.Any(e => e.Id == id);
        }
    }
}
