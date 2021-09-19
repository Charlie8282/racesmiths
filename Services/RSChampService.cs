using Microsoft.EntityFrameworkCore;
using racesmiths.Data;
using racesmiths.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Services
{
    public class RSChampService : IRSChampService
    {

        private readonly ApplicationDbContext _context;

        public RSChampService(ApplicationDbContext context)
        {
            _context = context;
        }

        //METHODS
        public async Task<bool> IsUserInChamp(string userId, int champId)
        {
            Champ champ = await _context.Champs
               .Include(u => u.ChampUsers)
               .FirstOrDefaultAsync(u => u.Id == champId);
            bool result = champ.ChampUsers.Any(u => u.Id == userId);
            return result;
        }
        public async Task<List<Champ>> ListUserChamps(string userId)
        {
            RSUser user = await _context.Users
                .Include(u => u.Champs)
                .ThenInclude(c => c.Events)
                .FirstOrDefaultAsync(p => p.Id == userId);



            List<Champ> champ = user.Champs.ToList();
            return champ;
        }
        public async Task AddUserToChamp(string userId, int champId)
        {
            if (!await IsUserInChamp(userId, champId))
            {
                try
                {
                    RSUser user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
                    Champ champ = await _context.Champs.FirstOrDefaultAsync(c => c.Id == champId);

                    champ.ChampUsers.Add(user);
                    await _context.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"*** ERROR *** - Error Adding user to champ.  --> {ex.Message}");
                    throw;
                }
            }
        }
        public async Task RemoveUserFromChamp(string userId, int champId)
        {
            if (await IsUserInChamp(userId, champId))
            {
                try
                {
                    RSUser champUser = _context.Users.Where(u => u.Id == userId).FirstOrDefault();
                    Champ champ = await _context.Champs.FirstOrDefaultAsync(c => c.Id == champId);

                    champ.ChampUsers.Remove(champUser);
                    await _context.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"***ERROR*** - Error removing user from champ. --> {ex.Message}");
                    throw;
                }

            }
        }
        public async Task<ICollection<RSUser>> UsersInChamp(int champId)
        {
            Champ champ = await _context.Champs
                .Include(u => u.ChampUsers)
                .FirstOrDefaultAsync(u => u.Id == champId);

            List<RSUser> champusers = champ.ChampUsers.ToList();
            return champusers;
        }
        public async Task<ICollection<RSUser>> UsersNotInChamp(int champId)
        {
            return await _context.Users.Where(u => IsUserInChamp(u.Id, champId).Result == false).ToListAsync();
        }

    }
}
