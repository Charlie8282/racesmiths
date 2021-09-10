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
        public string RSUserId { get; set; }
        //public Position Position { get; set; }
        public int Position { get; set; }
        public int RaceNumber { get; set; }
        public string RaceLength { get; set; }
        public string QualifyLength { get; set; }
        //public RSUser RaceUser { get; set; }



        public virtual Event Event { get; set; }
        public virtual ICollection<ClubUser> ClubUsers { get; set; } = new HashSet<ClubUser>();

    }
}
