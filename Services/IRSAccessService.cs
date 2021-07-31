using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Services
{
    public interface IRSAccessService
    {
        public Task<bool> CanInteractClub(string userId, int projectId, string roleName);
        public Task<bool> CanInteractChamp(string userId, int ticketId, string roleName);
    }
}
