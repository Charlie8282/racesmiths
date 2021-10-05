using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class Scoreboard
    {
        public int Id { get; set; }
        public int ChampId { get; set; }
        public int? Points { get; set; }
        public int? Bonus { get; set; }
        public int? Revoke { get; set; }
        public string RSUserId { get; set; }
        public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();
        public virtual ICollection<RSUser> Drivers { get; set; } = new HashSet<RSUser>();
    }
}
