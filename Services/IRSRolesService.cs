using racesmiths.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Services
{

    public interface IRSRolesService
    {
        public Task<bool> AddUserToRole(RSUser user, string roleName);
        public Task<bool> IsUserInRole(RSUser user, string roleName);
        public Task<IEnumerable<string>> ListUserRoles(RSUser user);
        public Task<bool> RemoveUserFromRole(RSUser user, string roleName);
        public Task<ICollection<RSUser>> UsersInRole(string roleName);
        public Task<ICollection<RSUser>> UsersNotInRole(IdentityRole role);

    }
}
