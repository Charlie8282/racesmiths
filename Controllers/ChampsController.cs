using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using racesmiths.Data;
using racesmiths.Models;
using racesmiths.Models.ViewModels;
using racesmiths.Services;

namespace racesmiths.Controllers
{
    public class ChampsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRSChampService _rschampService;
        private readonly UserManager<RSUser> _userManager;

        public ChampsController(ApplicationDbContext context, IRSChampService rSChampService, UserManager<RSUser> userManager)
        {
            _context = context;
            _rschampService = rSChampService;
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
                .Include(c => c.ChampUsers)
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
        public async Task<IActionResult> Create([Bind("ClubId,ClubUserId,ChampName,Game,System,Rounds,Laps,PracticeHours,PracticeMinutes,RaceHours,RaceMinutes,QualifyHours,QualifyMinutes,IGTimePractice,IGTimeQualify,IGTimeRace,Vehicle,IGDateRace,FormationLap,MandatoryPit,AutoStart,ForceInnerView,ForceDriveLine,ForceSetup,ForceGears,ForceAids,AllowTcs,AllowAbs,AllowStm,MechFailures,AllowGhost,ForceManualPit,FuelUsage,ForceCoolDown,PitStopErrors,RulesPenalty,TrackLimit,DriveThruPenalty,PitExitPenalty,RacingLicense,IsPublished,License,ExcludedVehicle,VehicleClass,StartType,Season,IGDateType,TimeProgression,WeatherProgression,AllowablePenalty,TireWear,DamageType,Multi1,Multi2,Multi3,Multi4,PracWeatherSlot1,PracWeatherSlot2,PracWeatherSlot3,PracWeatherSlot4,QualWeatherSlot1,QualWeatherSlot2,QualWeatherSlot3,QualWeatherSlot4,WeatherSlot1,WeatherSlot2,WeatherSlot3,WeatherSlot4,QualTimeProgression,QualWeatherProgression,PracTimeProgression,PracWeatherProgression,Description,StartDate,Status,SelectedUsers,NoPractice,NoQualify,NoRealism,NoRules,NoRace")] Champ champ)
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


        [HttpGet]
        [Authorize(Roles = "Admin, ClubManager")]
        public async Task<IActionResult> AssignUsers(int id)
        {
            ManageChampUsersViewModel model = new();
            Champ champ = await _context.Champs
                .Include(p => p.ChampUsers)
                .FirstAsync(p => p.Id == id);

            model.Champ = champ;
            List<RSUser> users = await _context.Users.ToListAsync();
            model.Users = new MultiSelectList(users, "Id", "Gamertag", champ.ChampUsers);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, ClubManager")]
        public async Task<IActionResult> AssignUsers(ManageChampUsersViewModel model)
        {

            if (ModelState.IsValid)
            {
                if (model.SelectedUsers != null)
                {
                    var currentMembers = await _context.Champs.Include(p => p.ChampUsers).FirstOrDefaultAsync(p => p.Id == model.Champ.Id);
                    List<string> memberIds = currentMembers.ChampUsers.Select(u => u.Id).ToList();
                    memberIds.ForEach(i => _rschampService.AddUserToChamp(i, model.Champ.Id));
                  
                    foreach (string id in model.SelectedUsers)
                    {
                        await _rschampService.AddUserToChamp(id, model.Champ.Id);
                    }
                    return RedirectToAction("Details", "Champs", new { id = model.Champ.Id });
                }
                else
                {

                }
                return View(model);

            }

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, ClubManager")]
        public async Task<IActionResult> RemoveUsers(int id)
        {
            ManageChampUsersViewModel model = new();
            Champ champ = await _context.Champs
                .Include(p => p.ChampUsers)
                .FirstAsync(p => p.Id == id);
            model.Champ = champ;
            model.Users = new MultiSelectList(champ.ChampUsers, "Id", "Gamertag");
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, ClubManager")]
        public async Task<IActionResult> RemoveUsers(ManageChampUsersViewModel model)
        {
            if (ModelState.IsValid)
            {

                if (model.SelectedUsers != null)
                {
                    foreach (string id in model.SelectedUsers)
                    {
                        await _rschampService.RemoveUserFromChamp(id, model.Champ.Id);
                    }
                    return RedirectToAction("Details", "Champs", new { id = model.Champ.Id });
                }
                else
                {
                    return View(model);
                }
            }
            return RedirectToAction("Details", "Champs", new { id = model.Champ.Id });
        }
    }
}
