//using racesmiths.Areas.Identity.Pages.Account;
using racesmiths.Models;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project = racesmiths.Models.Club;
using racesmiths.Data;
using Microsoft.AspNetCore.Identity;
using RSUser = racesmiths.Models.RSUser;
using System.Diagnostics;

namespace racesmiths.Services
{
    public class RSClubService : IRSClubService
    {

        private readonly ApplicationDbContext _context;

        public RSClubService(ApplicationDbContext context)
        {
            _context = context;
        }

        //METHODS
        public async Task<bool> IsUserInClub(string userId, int clubId)
        {
            Club club = await _context.Clubs
               .Include(u => u.ClubUsers)
               .ThenInclude(u => u.User)
               .FirstOrDefaultAsync(u => u.Id == clubId);
            bool result = club.ClubUsers.Any(u => u.UserId == userId);
            return result;
        }
        public async Task<List<Club>> ListUserClubs(string userId)
        {
            RSUser user = await _context.Users
                 .Include(p => p.ClubUsers)
                 .ThenInclude(p => p.Club).ThenInclude(p => p.Champs)
                 .FirstOrDefaultAsync(p => p.Id == userId);

            List<Project> projects = user.ClubUsers.Select(p => p.Club).ToList();
            return projects;
        }
        public async Task AddUserToClub(string userId, int clubId)
        {
            if (!await IsUserInClub(userId, clubId))
            {
                try
                {
                    await _context.ClubUsers.AddAsync(new ClubUser { ClubId = clubId, UserId = userId });
                    await _context.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"*** ERROR *** - Error Adding user to club.  --> {ex.Message}");
                    throw;
                }
            }
        }
        public async Task RemoveUserFromClub(string userId, int clubId)
        {
            try
            {
                ClubUser clubUser = _context.ClubUsers.Where(u => u.UserId == userId && u.ClubId == clubId).FirstOrDefault();

                _context.ClubUsers.Remove(clubUser);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"***ERROR*** - Error removing user from club. --> {ex.Message}");
                throw;
            }
        }
        public async Task<ICollection<RSUser>> UsersInClub(int clubId)
        {
            Club club = await _context.Clubs
                .Include(u => u.ClubUsers)
                .ThenInclude(u => u.User)
                .FirstOrDefaultAsync(u => u.Id == clubId);

            List<RSUser> clubusers = club.ClubUsers.Select(p => p.User).ToList();
            return clubusers;
        }
        public async Task<ICollection<RSUser>> UsersNotInClub(int clubId)
        {
            return await _context.Users.Where(u => IsUserInClub(u.Id, clubId).Result == false).ToListAsync();
        }

    }
}


