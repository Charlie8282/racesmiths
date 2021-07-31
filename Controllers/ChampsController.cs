using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using racesmiths.Data;
using racesmiths.Services;
using racesmiths.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace racesmiths.Controllers
{
    [Authorize]
    public class ChampsController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IRSClubService _clubService;
        private readonly UserManager<RSUser> _userManager;
        private readonly IRSAccessService _accessService;
        public ChampsController(ApplicationDbContext context, IRSClubService projectService, UserManager<RSUser> userManager, IRSAccessService accessService)
        {
            _context = context;
            _clubService = projectService;
            _userManager = userManager;
            _accessService = accessService;
        }

        // GET: Champs
        public async Task<IActionResult> Index(string userId)
        {
            var projectIds = new List<int>();
            var model = new List<Champ>();
            var userProjects = _context.ClubUsers.Where(pu => pu.UserId == userId).ToList();
            foreach (var record in userProjects)
            {
                projectIds.Add(_context.Clubs.Find(record.ClubId).Id);

            }
            foreach (var id in projectIds)
            {
                var champs = _context.Champs.Where(t => t.ClubId == id).ToList();
                model.AddRange(champs);
            }

            var applicationDbContext = _context.Champs
                .Include(t => t.OwnerUser)
                .Include(t => t.Club);
            return View(await applicationDbContext.ToListAsync());
        }


        public IActionResult MyChamps()
        {
            var model = new List<Champ>();
            var userId = _userManager.GetUserId(User);

            if (User.IsInRole("Admin"))
            {
                model = _context.Champs
                    .Include(t => t.OwnerUser)
                    .Include(t => t.Club)
                    .ToList();
            }
            else if (User.IsInRole("Director"))
            {
                var projectIds = new List<int>();
                var userProjects = _context.ClubUsers.Where(pu => pu.UserId == userId).ToList();


                foreach (var record in userProjects)
                {
                    projectIds.Add(record.ClubId);
                }
                foreach (var id in projectIds)
                {
                    var champs = _context.Champs.Where(t => t.ClubId == id)
                    .Include(t => t.OwnerUser)
                    .Include(t => t.Club)
                    .ToList();
                    model.AddRange(champs);
                }
            }
            else if (User.IsInRole("Driver"))
            {
                model = _context.Champs
                    .Include(t => t.OwnerUser)
                    .Include(t => t.Club)
                    .ToList();
            }
            else if (User.IsInRole("FreeAgent"))
            {
                model = _context.Champs
                    .Include(t => t.OwnerUser)
                    .Include(t => t.Club)
                    .ToList();
            }
            else
            {
                return NotFound();
            }
            return View(model);
        }
        // GET: Champs/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = _userManager.GetUserId(User);
            var roleName = _userManager.GetRolesAsync(await _userManager.GetUserAsync(User)).Result.FirstOrDefault();

            var champ = await _context.Champs
                           .Include(t => t.OwnerUser)
                       .FirstOrDefaultAsync(m => m.Id == id);
            if (champ == null)
            {
                return NotFound();
            }

            return View(champ);

        }

        [Authorize(Roles = "Admin, Director, Driver, FreeAgent")]
        // GET: Champs/Create
        public IActionResult Create(int? Id, IFormFile attachment)
        {
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "Name");
            return View();
        }

        // POST: Champs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description,ClubId,")] Champ champ)
        {

            if (ModelState.IsValid)
            {

                _context.Add(champ);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");

            }
            ViewData["OwnerUserId"] = new SelectList(_context.Users, "Id", "Id", champ.OwnerUserId);
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "Name", champ.ClubId);
            return View(champ);

        }

        // GET: Champs/Edit/5
        [Authorize(Roles = "Admin, Director, Driver, FreeAgent")]
        public async Task<IActionResult> Edit(int? id, IFormFile attachment)
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

            var userId = _userManager.GetUserId(User);
            var roleName = _userManager.GetRolesAsync(await _userManager.GetUserAsync(User)).Result.FirstOrDefault();
            if (await _accessService.CanInteractChamp(userId, (int)id, roleName))
            {
                await _clubService.UsersInClub(champ.ClubId);

                ViewData["OwnerUserId"] = new SelectList(_context.Users, "Id", "FullName", champ.OwnerUserId);
                ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "Name", champ.ClubId);
                return View(champ);
            }
            return RedirectToAction("Index");
        }

        // POST: Champs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Created,ClubId,OwnerUserId")] Champ champ)
        {
            if (id != champ.Id)
            {
                return NotFound();
            }

            Champ oldTicket = await _context.Champs
                //.Where(t => t.Id == champ.Id)
                //.Include(d => d.Description)
                .Include(o => o.OwnerUser)
                .Include(t => t.Club)
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Id == champ.Id);



            if (ModelState.IsValid)
            {

                {
                    champ.Updated = DateTime.Now;
                    _context.Update(champ);
                    await _context.SaveChangesAsync();
                }

            }
            ViewData["OwnerUserId"] = new SelectList(_context.Users, "Id", "Id", champ.OwnerUserId);
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "Name", champ.ClubId);
            return RedirectToAction("Details", "Champs", new { id = champ.Id });

        }

        private bool ChampExists(int id)
        {
            return _context.Champs.Any(e => e.Id == id);
        }

    }
}
