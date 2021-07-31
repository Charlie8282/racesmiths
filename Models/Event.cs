using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int ChampId { get; set; }
        public bool Completed { get; set; }
        public RSUser OwnerUser { get; set; }

        public DateTime Created { get; set; }
        public DateTime Scheduled { get; set; }


        [Required]
        [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string TrackName { get; set; }
        public int RoundNumber { get; set; }
        //public string OldValue { get; set; }
        //public string NewValue { get; set; }
        public string FileName { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<Race> Races { get; set; }
        //public virtual ICollection<RaceResult> RaceResults { get; set; }
        //public virtual ICollection<Attachment> RaceAttachments { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        //public virtual ICollection<TicketHistory> Histories { get; set; }

    }
}
