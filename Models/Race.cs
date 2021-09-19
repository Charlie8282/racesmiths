using racesmiths.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class Race
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string TrackName { get; set; }
        public int? Position { get; set; }
        public int? Points { get; set; }
        public int? Bonus { get; set; }
        public int? Revoke { get; set; }


        public virtual Event Event { get; set; }

        public virtual ICollection<RSUser> ClubUsers { get; set; } = new HashSet<RSUser>();

    }
}
