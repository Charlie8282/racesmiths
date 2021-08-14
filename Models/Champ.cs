using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using racesmiths.Enums;

namespace racesmiths.Models
{
    public class Champ
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public string RSUserId { get; set; }
        public string ClubUserId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Championship name")]
        public string ChampName { get; set; }

        [Required]
        public int RaceCount { get; set; }
        public string Rules { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Championship description")]
        public string Description { get; set; }
        public string Settings { get; set; }

        public ChampType ChampType { get; set; }
        public DateTime? StartDate { get; set; }
        public Status Status { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }
        public byte[] ImageData { get; set; }


        //NAVIGATION
        public Club Club { get; set; }
        //public virtual ICollection<RSUser> RSUsers { get; set; } = new HashSet<RSUser>();
        public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();

    }
}
