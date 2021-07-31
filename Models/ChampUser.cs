using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class ChampUser
    {
        public string UserId { get; set; }
        public RSUser User { get; set; }
        public int ChampId { get; set; }
        public Champ Champ { get; set; }
    }
}
