using racesmiths.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace racesmiths.Services
{
    public interface IRSHistoriesService
    {
        public Task AddHistory(Champ oldChamp, Champ newChamp, string userId);
      

    }
    }
