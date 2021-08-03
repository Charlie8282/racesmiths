using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class Champ
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int ClubId { get; set; }
        public string Club { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Updated { get; set; }
        [Required]
        public int RaceCount { get; set; }
        public string OwnerUserId { get; set; }
        public string OwnerUser { get; set; }
        public string Description { get; set; }
        public string Rules { get; set; }
        public string Settings { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }
        public byte[] ImageData { get; set; }
        public virtual RSUser User { get; set; }



    }
}
