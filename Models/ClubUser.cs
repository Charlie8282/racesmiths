using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class ClubUser
    {
        public string UserId { get; set; }
        public RSUser User { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
    }
}
