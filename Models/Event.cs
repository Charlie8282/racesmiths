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
        //public string EventUserId { get; set; }

        [Display(Name = "Round")]
        public int RoundNumber { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string TrackName { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Event description")]
        public string Description { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Event settings")]
        public string Settings { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date created")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date scheduled")]
        public DateTime? Scheduled { get; set; }


        public string FileName { get; set; }
        public byte[] Image { get; set; }

        //NAVIGATION
        public virtual Champ Champ { get; set; }
        //public RSUser EventUser { get; set; }

        public virtual ICollection<RSUser> ClubUsers { get; set; } = new HashSet<RSUser>();

        public virtual ICollection<Race> Races { get; set; } = new HashSet<Race>();

    }
}
