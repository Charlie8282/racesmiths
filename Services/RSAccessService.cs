using racesmiths.Data;
using Microsoft.EntityFrameworkCore;
using racesmiths.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Services
{

    public class RSAccessService : IRSAccessService
    {
        private readonly ApplicationDbContext _context;
        public RSAccessService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CanInteractClub(string userId, int clubId, string roleName)
        {
            switch (roleName)
            {
                case "Admin":
                    return true;
                case "Director":
                    if (await _context.ClubUsers.Where(pu => pu.UserId == userId && pu.ClubId == clubId).AnyAsync())
                    {
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }
        public async Task<bool> CanInteractChamp(string userId, int champId, string roleName)
        {
            bool result = false;
            switch (roleName)
            {

                case "Admin":
                    result = true;
                    break;
                case "Director":
                    var clubId = (await _context.Champs.FindAsync(champId)).ClubId;
                    if (await _context.ClubUsers.Where(pu => pu.ClubId == clubId && pu.UserId == userId).AnyAsync())
                    //if (await _context.ProjectUsers.Where(pu => pu.UserId == userId && pu.ProjectId == projectId).AnyAsync())
                    {
                        result = true;
                    }
                    break;

                default:
                    break;
            }
            return result;
        }
    }

}



//public async Task<bool> CanInteractTicket(string userId, int ticketId, string roleName)
//{
//    bool result = false;
//    switch (roleName)
//    {
//        case "Admin":
//            result = true;
//            break;
//        case "ProjectManager":
//            var projectId = (await _context.Tickets.FindAsync(ticketId)).ProjectId;
//            if (await _context.ProjectUsers.Where(pu => pu.UserId == userId && pu.ProjectId == projectId).AnyAsync())
//            {
//                result = true;
//            }
//            break;
//        case "Developer":
//            if (await _context.Tickets.Where(t => t.DeveloperUserId == userId && t.Id == ticketId).AnyAsync())
//            {
//                result = true;
//            }
//            break;
//        case "Submitter":
//            if (await _context.Tickets.Where(t => t.OwnerUserId == userId && t.Id == ticketId).AnyAsync())
//            {
//                result = true;
//            }
//            break;
//        default:
//            break;
//    }
//    return result;
//}
//    }

//}
