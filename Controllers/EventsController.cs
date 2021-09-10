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
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Event.Include(c => c.Champ);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cevent = await _context.Event
                .Include(c => c.Champ)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cevent == null)
            {
                return NotFound();
            }

            return View(cevent);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            ViewData["ChampId"] = new SelectList(_context.Champs, "Id", "ChampName");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChampId,RSUserId,RoundNumber,TrackName,Description,Settings,Scheduled")] Event cevent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cevent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChampId"] = new SelectList(_context.Champs, "Id", "ChampName", cevent.ChampId);
            return View(cevent);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cevent = await _context.Event.FindAsync(id);
            if (cevent == null)
            {
                return NotFound();
            }
            ViewData["ChampId"] = new SelectList(_context.Champs, "Id", "ChampName", cevent.ChampId);
            return View(cevent);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ChampId,RSUserId,RoundNumber,TrackName,Description,Settings,Created,Scheduled,FileName,Image")] Event cevent)
        {
            if (id != cevent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cevent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(cevent.Id))
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
            ViewData["ChampId"] = new SelectList(_context.Champs, "Id", "ChampName", cevent.ChampId);
            return View(cevent);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cevent = await _context.Event
                .Include(c => c.Champ)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cevent == null)
            {
                return NotFound();
            }

            return View(cevent);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cevent = await _context.Event.FindAsync(id);
            _context.Event.Remove(cevent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Id == id);
        }
    }
}
