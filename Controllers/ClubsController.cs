using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using racesmiths.Data;
using racesmiths.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using racesmiths.Services;
using racesmiths.Models.ViewModels;

namespace racesmiths.Controllers
{
    [Authorize]
    public class ClubsController : Controller
    {
        private readonly UserManager<RSUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IRSClubService _rsClubService;
        public ClubsController(ApplicationDbContext context, IRSClubService bTProjectService, UserManager<RSUser> userManager)
        {
            _context = context;
            _rsClubService = bTProjectService;
            _userManager = userManager;
        }

        // GET: Clubs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clubs.ToListAsync());
        }
        public async Task<IActionResult> MyClubs()
        {
            var model = new List<Club>();
            var userId = _userManager.GetUserId(User);

            if (User.IsInRole("Admin"))
            {
                model = _context.Clubs.Include(p => p.ClubUsers).ToList();
            }

            else if (User.IsInRole("Director"))
            {
                var projectIds = new List<int>();
                model = new List<Club>();
                //grab data that I need here
                var userProjects = _context.ClubUsers.Where(pu => pu.UserId == userId).ToList();

                foreach (var record in userProjects)
                {
                    projectIds.Add(_context.Clubs.Find(record.ClubId).Id);
                }
                foreach (var id in projectIds)
                {
                    var club = _context.Clubs.Where(t => t.Id == id).ToList();
                    model.AddRange(club);
                }

            }

            else if (User.IsInRole("Driver"))
            {
                model = await _rsClubService.ListUserClubs(userId);

            }

            else if (User.IsInRole("FreeAgent"))
            {
                model = await _rsClubService.ListUserClubs(userId);

            }
            else
            {
                return NotFound();
            }
            return View(model);
        }
        //GET: Clubs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var club = await _context.Clubs
                .Include(p => p.ClubUsers)
                .ThenInclude(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            club.Champs = await _context.Champs
                .Where(t => t.ClubId == id)
                //.Include(t => t.OwnerUser)
                .ToListAsync();

            if (club == null)
            {
                return NotFound();
            }
            List<RSUser> Users = _context.Users.ToList();
            return View(club);
        }

        // GET: Clubs/Create
        [Authorize(Roles = "Admin, Director")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clubs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Director")]
        public async Task<IActionResult> Create([Bind("Id,Name")] Club club)
        {

            if (ModelState.IsValid)
            {
                _context.Add(club);
                await _context.SaveChangesAsync();
                ClubUser record = new ClubUser { UserId = _userManager.GetUserId(User), ClubId = club.Id };
                _context.ClubUsers.Add(record);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");

            }
            return View(club);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, ProjectManager")]
        public async Task<IActionResult> CreateProjectFromTable([Bind("Id,Name")] Club club)
        {
            if (!User.IsInRole("Demo"))
            {
                if (ModelState.IsValid)
                {
                    _context.Add(club);
                    await _context.SaveChangesAsync();
                    ClubUser record = new ClubUser { UserId = _userManager.GetUserId(User), ClubId = club.Id };
                    _context.ClubUsers.Add(record);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Clubs");

                }

                return View(club);
            }
            else
            {
                TempData["DemoLockout"] = "Your changes will not be saved.  To make changes to the database please log in as a full user.";

                return RedirectToAction("Index", "Clubs");


            }
        }

        // GET: Clubs/Edit/5
        [Authorize(Roles = "Admin, ProjectManager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var club = await _context.Clubs.FindAsync(id);
            if (club == null)
            {
                return NotFound();
            }
            return View(club);
        }

        // POST: Clubs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, ProjectManager")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ImagePath,ImageData")] Club club)
        {
            if (id != club.Id)
            {
                return NotFound();
            }
            if (!User.IsInRole("Demo"))
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(club);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ClubExists(club.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction("Details", "Clubs", new { id = club.Id });
                }
                return RedirectToAction("Details", "Clubs", new { id = club.Id });

            }
            return View(club);
        }

        private bool ClubExists(int id)
        {
            return _context.Clubs.Any(e => e.Id == id);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, ProjectManager")]
        public async Task<IActionResult> AssignUsers(int id)
        {
            var model = new ManageClubUsersViewModel();
            var club = _context.Clubs
                .Include(p => p.ClubUsers)
                .ThenInclude(p => p.User)
                .FirstAsync(p => p.Id == id);

            model.Club = await club;
            List<RSUser> users = await _context.Users.ToListAsync();
            List<RSUser> members = (List<RSUser>)await _rsClubService.UsersInClub(id);
            model.Users = new MultiSelectList(users, "Id", "FullName", members);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, ProjectManager")]
        public async Task<IActionResult> AssignUsers(ManageClubUsersViewModel model)
        {
            if (!User.IsInRole("Demo"))
            {
                if (ModelState.IsValid)
                {
                    if (model.SelectedUsers != null)
                    {
                        var currentMembers = await _context.Clubs.Include(p => p.ClubUsers).FirstOrDefaultAsync(p => p.Id == model.Club.Id);
                        List<string> memberIds = currentMembers.ClubUsers.Select(u => u.UserId).ToList();
                        memberIds.ForEach(i => _rsClubService.AddUserToClub(i, model.Club.Id));
                        //foreach (string id in memberIds)
                        //{
                        //    await _rsClubService.RemoveUserFromProject(id, model.Club.Id);
                        //}
                        foreach (string id in model.SelectedUsers)
                        {
                            await _rsClubService.AddUserToClub(id, model.Club.Id);
                        }
                        return RedirectToAction("Details", "Clubs", new { id = model.Club.Id });
                    }
                    else
                    {

                    }
                    return View(model);

                }

            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, ProjectManager")]
        public async Task<IActionResult> RemoveUsers(int id)
        {
            var model = new ManageClubUsersViewModel();
            //var club = _context.Clubs.Find(id);
            var club = _context.Clubs
                .Include(p => p.ClubUsers)
                .ThenInclude(p => p.User)
                .FirstAsync(p => p.Id == id);
            model.Club = await club;
            List<RSUser> members = (List<RSUser>)await _rsClubService.UsersInClub(id);
            model.Users = new MultiSelectList(members, "Id", "FullName");
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, ProjectManager")]
        public async Task<IActionResult> RemoveUsers(ManageClubUsersViewModel model)
        {
            if (!User.IsInRole("Demo"))
            {
                if (ModelState.IsValid)
                {

                    if (model.SelectedUsers != null)
                    {
                        foreach (string id in model.SelectedUsers)
                        {
                            await _rsClubService.RemoveUserFromClub(id, model.Club.Id);
                        }
                        return RedirectToAction("Details", "Clubs", new { id = model.Club.Id });
                    }
                    else
                    {
                        return View(model);
                    }
                }
            }
            return RedirectToAction("Details", "Clubs", new { id = model.Club.Id });
        }
    }
}
