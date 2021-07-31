using racesmiths.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace racesmiths.Services
{

    public class RSRolesService : IRSRolesService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<RSUser> _userManager;
        public RSRolesService(RoleManager<IdentityRole> roleManager, UserManager<RSUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<bool> AddUserToRole(RSUser user, string roleName)
        {
            var result = await _userManager.AddToRoleAsync(user, roleName);
            return result.Succeeded;
        }

        public async Task<bool> IsUserInRole(RSUser user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
           
        }

        public async Task<IEnumerable<string>> ListUserRoles(RSUser user)
        {
            return await _userManager.GetRolesAsync(user);
     
        }

        public async Task<bool> RemoveUserFromRole(RSUser user, string roleName)
        {
            var result = await _userManager.RemoveFromRoleAsync(user, roleName);
            return result.Succeeded;
        }

        public async Task<ICollection<RSUser>> UsersInRole(string roleName)
        {
            var users = await _userManager.GetUsersInRoleAsync(roleName);
            return users;
            //return await _userManager.Users.Where(u => IsUserInRole(u, role.Name).Result == false);
        }


        //public async Task<ICollection<RSUser>> UsersNotInRole(string roleName)
        //{
        //    var inRole = await _userManager.GetUsersInRoleAsync(roleName);
        //    var users = await _userManager.Users.ToListAsync();
        //    return users.Except(inRole);
        //}


        public async Task<ICollection<RSUser>> UsersNotInRole(IdentityRole role)
        {
            var roleId = await _roleManager.GetRoleIdAsync(role);
            return _userManager.Users.Where(u => IsUserInRole(u, role.Name).Result == false).ToList();
        }
        //public async Task<IEnumerable<RSUser>> UsersNotInRoles(List<string> roleNames)
        //{
        //    List<RSUser> inRole = new List<RSUser>();
        //    foreach (var role in roleNames)
        //    {
        //        inRole.AddRange(await _userManager.GetUsersInRoleAsync(role));
        //    }
        //    var users = await _userManager.Users.ToListAsync();
        //    return users.Except(inRole);
        //}
    }
}
