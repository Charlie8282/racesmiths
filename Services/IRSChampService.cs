using racesmiths.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Services
{
    public interface IRSChampService
    {
        public Task<bool> IsUserInChamp(string userId, int champId);

        public Task<List<Champ>> ListUserChamps(string userId);

        public Task AddUserToChamp(string userId, int champId);

        public Task RemoveUserFromChamp(string userId, int champId);

        public Task<ICollection<RSUser>> UsersInChamp(int champId);

        public Task<ICollection<RSUser>> UsersNotInChamp(int champId);
    }
}
