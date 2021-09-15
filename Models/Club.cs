using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace racesmiths.Models
{
    public class Club
    {
        public int Id { get; set; }
        //public string RSUserId { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        public string ClubName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date created")]
        public DateTime Created { get; set; }

        public string Rules { get; set; }
        public string Roles { get; set; }
        public string JoinRequests { get; set; }
        public string[] SelectedUsers { get; set; }
        public string ImagePath { get; set; }

        [Display(Name = "Club image")]
        public byte[] ImageData { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        [Display(Name = "Avatar")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }


        //NAVIGATION
        public virtual ICollection<RSUser> ClubUsers { get; set; } = new HashSet<RSUser>();
        //public List<RSUser> Users { get; set; }
        public virtual ICollection<Champ> Champs { get; set; } = new HashSet<Champ>();

    }
}
