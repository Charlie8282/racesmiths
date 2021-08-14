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
        public Position Position { get; set; }



        public virtual Event Event { get; set; }
    }
}
