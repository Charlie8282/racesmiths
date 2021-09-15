using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using racesmiths.Data;
using racesmiths.Models;
using racesmiths.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using racesmiths.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace racesmiths.Controllers
{
    public class UserRolesController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IRSRolesService _rolesService;
        private readonly UserManager<RSUser> _userManager;

        public UserRolesController(ApplicationDbContext context, IRSRolesService rolesService, UserManager<RSUser> userManager)
        {
            _context = context;
            _rolesService = rolesService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin, ProjectManager")]
        public async Task<IActionResult> ManageUserRoles()
        {
            List<ManageUserRolesViewModel> model = new List<ManageUserRolesViewModel>();
            List<RSUser> users = _context.Users.ToList();

            foreach (var user in users)
            {
                ManageUserRolesViewModel vm = new ManageUserRolesViewModel();
                vm.User = user;
                var selected = (await _rolesService.ListUserRoles(user)).FirstOrDefault();
                vm.Roles = new SelectList(_context.Roles, "Name", "Name", selected);
                model.Add(vm);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ManageUserRoles(ManageUserRolesViewModel rsuser)
        {
            RSUser user = await _context.Users.FindAsync(rsuser.User.Id);

            IEnumerable<string> roles = await _rolesService.ListUserRoles(user);
            await _userManager.RemoveFromRolesAsync(user, roles);
            var userRoles = rsuser.SelectedRole;

            foreach (var role in userRoles)
            {
                if (Enum.TryParse(userRoles, out Roles roleValue))
                {
                    await _rolesService.AddUserToRole(user, userRoles);
                    //return RedirectToAction("ManageUserRoles");
                }
            }

            return RedirectToAction("ManageUserRoles");
        }
    }
}
