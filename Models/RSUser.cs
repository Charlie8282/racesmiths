using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace racesmiths.Models
{
    public class RSUser : IdentityUser
    {

        [Required]
        [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string Gamertag { get; set; }
        //public int? ClubId { get; set; }

        [Display(Name = "Avatar")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        //public int ClubId { get; set; }


        public virtual ICollection<Club> Clubs { get; set; } = new HashSet<Club>();
        //public virtual ICollection<Champ> Champs { get; set; } = new HashSet<Champ>();
        //public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();
        //public virtual ICollection<Race> Races { get; set; } = new HashSet<Race>();

    }
}
