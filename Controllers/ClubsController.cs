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
using racesmiths.Enums;
using racesmiths.Models;
using racesmiths.Models.ViewModels;
using racesmiths.Services;

namespace racesmiths.Controllers
{
    public class ClubsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<RSUser> _userManager;
        private readonly SignInManager<RSUser> _signInManager;
        private readonly IRSClubService _rsClubService;

        public ClubsController(ApplicationDbContext context, UserManager<RSUser> userManager, SignInManager<RSUser> signInManager, IRSClubService rSClubService)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _rsClubService = rSClubService;
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

            else if (User.IsInRole("ClubManager"))
            {
                var clubIds = new List<int>();
                model = new List<Club>();
                var userClubs = _context.ClubUsers.Where(pu => pu.Id == userId).ToList();

                foreach (var record in userClubs)
                {
                    clubIds.Add(_context.Clubs.Find(record.Id).Id);
                }
                foreach (var id in clubIds)
                {
                    var club = _context.Clubs.Where(t => t.Id == id).ToList();
                    model.AddRange(club);
                }

            }

            else if (User.IsInRole("Driver"))
            {
                model = await _rsClubService.ListUserClubs(userId);

            }

            else if (User.IsInRole("NewUser"))
            {
                model = await _rsClubService.ListUserClubs(userId);

            }
            else
            {
                return NotFound();
            }
            return View(model);
        }


        // GET: Clubs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var club = await _context.Clubs
                .Include(c => c.Champs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (club == null)
            {
                return NotFound();
            }

            return View(club);
        }

        // GET: Clubs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clubs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClubName,Created,Rules")] Club club)
        {
            if (ModelState.IsValid)
            {
                club.Created = DateTime.Now;
                _context.Add(club);
                await _context.SaveChangesAsync();
                    
                RSUser user = await _userManager.GetUserAsync(User);

                club.ClubUsers.Add(user);
                await _context.SaveChangesAsync();
                await _userManager.AddToRoleAsync(user, RSRoles.ClubManager.ToString());
                await _signInManager.RefreshSignInAsync(user);

                return RedirectToAction("Details", "Clubs", new { id = club.Id });
            }
            return View(club);
        }

        // GET: Clubs/Edit/5
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,RSUserId,ClubName,Created,Rules,Roles,JoinRequests,ImagePath,ImageData,FileName,FileData")] Club club)
        {
            if (id != club.Id)
            {
                return NotFound();
            }

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
                return RedirectToAction(nameof(Index));
            }
            return View(club);
        }

        // GET: Clubs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var club = await _context.Clubs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (club == null)
            {
                return NotFound();
            }

            return View(club);
        }

        // POST: Clubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var club = await _context.Clubs.FindAsync(id);
            _context.Clubs.Remove(club);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClubExists(int id)
        {
            return _context.Clubs.Any(e => e.Id == id);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, ClubManager")]
        public async Task<IActionResult> AssignUsers(int id)
        {
            ManageClubUsersViewModel model = new();
            Club club = await _context.Clubs
                .Include(p => p.ClubUsers)
                .FirstAsync(p => p.Id == id);

            model.Club = club;
            List<RSUser> users = await _context.Users.ToListAsync();
            //List<RSUser> members = (await _rsClubService.UsersInClub(id)).ToList();
            model.Users = new MultiSelectList(users, "Id", "Gamertag", club.ClubUsers);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, ClubManager")]
        public async Task<IActionResult> AssignUsers(ManageClubUsersViewModel model)
        {

            if (ModelState.IsValid)
            {
                if (model.SelectedUsers != null)
                {
                    var currentMembers = await _context.Clubs.Include(p => p.ClubUsers).FirstOrDefaultAsync(p => p.Id == model.Club.Id);
                    List<string> memberIds = currentMembers.ClubUsers.Select(u => u.Id).ToList();
                    memberIds.ForEach(i => _rsClubService.AddUserToClub(i, model.Club.Id));
                    //foreach (string id in memberIds)
                    //{
                    //    await _btProjectService.RemoveUserFromProject(id, model.Project.Id);
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

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, ClubManager")]
        public async Task<IActionResult> RemoveUsers(int id)
        {
            ManageClubUsersViewModel model = new();
            Club club = await _context.Clubs
                .Include(p => p.ClubUsers)
                .FirstAsync(p => p.Id == id);
            model.Club = club;
            //List<RSUser> members = (List<RSUser>)await _rsClubService.UsersInClub(id);
            model.Users = new MultiSelectList(club.ClubUsers, "Id", "Gamertag");
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, ClubManager")]
        public async Task<IActionResult> RemoveUsers(ManageClubUsersViewModel model)
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
            return RedirectToAction("Details", "Clubs", new { id = model.Club.Id });
        }
    }
}
