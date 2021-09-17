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
        //public string RSUserId { get; set; }
        //public Position Position { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public int RaceNumber { get; set; }
        public int? Laps { get; set; }
        public string RaceLength { get; set; }
        public string QualifyLength { get; set; }
        //public RSUser RaceUser { get; set; }



        public virtual Event Event { get; set; }

        //public virtual Event Events { get; set; } = new HashSet<Event>();
        public virtual ICollection<RSUser> ClubUsers { get; set; } = new HashSet<RSUser>();

    }
}
