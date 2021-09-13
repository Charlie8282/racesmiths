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
               .FirstOrDefaultAsync(u => u.Id == clubId);
            bool result = club.ClubUsers.Any(u => u.Id == userId);
            return result;
        }
        public async Task<List<Club>> ListUserClubs(string userId)
        {
            RSUser user = await _context.Users
                .Include(u => u.Clubs).ThenInclude(c => c.Champs)
                .FirstOrDefaultAsync(p => p.Id == userId);



            List<Club> clubs = user.Clubs.ToList();
            return clubs;
        }
        public async Task AddUserToClub(string userId, int clubId)
        {
            if (!await IsUserInClub(userId, clubId))
            {
                try
                {
                    RSUser user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
                    Club club = await _context.Clubs.FirstOrDefaultAsync(c => c.Id == clubId);

                    club.ClubUsers.Add(user);
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
            if (await IsUserInClub(userId, clubId))
            {
                try
                {
                    RSUser clubUser = _context.Users.Where(u => u.Id == userId).FirstOrDefault();
                    Club club = await _context.Clubs.FirstOrDefaultAsync(c => c.Id == clubId);

                    club.ClubUsers.Remove(clubUser);
                    await _context.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"***ERROR*** - Error removing user from club. --> {ex.Message}");
                    throw;
                }

            }
        }
        public async Task<ICollection<RSUser>> UsersInClub(int clubId)
        {
            Club club = await _context.Clubs
                .Include(u => u.ClubUsers)
                .FirstOrDefaultAsync(u => u.Id == clubId);

            List<RSUser> clubusers = club.ClubUsers.ToList();
            return clubusers;
        }
        public async Task<ICollection<RSUser>> UsersNotInClub(int clubId)
        {
            return await _context.Users.Where(u => IsUserInClub(u.Id, clubId).Result == false).ToListAsync();
        }

    }
}


