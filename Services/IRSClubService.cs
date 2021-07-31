using racesmiths.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Services
{
    public interface IRSClubService
    {
        public Task<bool> IsUserInClub(string userId, int clubId);

        public Task<List<Club>> ListUserClubs(string userId);

        public Task AddUserToClub(string userId, int clubId);

        public Task RemoveUserFromClub(string userId, int clubId);

        public Task<ICollection<RSUser>> UsersInClub(int clubId);

        public Task<ICollection<RSUser>> UsersNotInClub(int clubId);

       
    }
}
