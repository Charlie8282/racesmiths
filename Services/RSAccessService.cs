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
                case "ClubManager":
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
                case "ClubManager":
                    var clubId = (await _context.Champs.FindAsync(champId)).ClubId;
                    if (await _context.ClubUsers.Where(pu => pu.ClubId == clubId && pu.UserId == userId).AnyAsync())
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



