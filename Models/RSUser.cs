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

        //public bool Absent { get; set; }
        //public int? ClubId { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string Gamertag { get; set; }

        [Display(Name = "Avatar")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        public List<ClubUser> ClubUsers { get; set; }
        public virtual ICollection<Event> Races { get; set; }
        public virtual ICollection<Champ> Champs { get; set; }

        //[Required]
        //[StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        //public string FirstName { get; set; }

        //[Required]
        //[StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        //public string LastName { get; set; }

    }
}
