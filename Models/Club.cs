using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string OwnerUserId { get; set; }
        public RSUser OwnerUser { get; set; }
        public List<RSUser> RSUsers { get; set; }
        public List<Champ> Champs { get; set; }
        public string ImagePath { get; set; }
        public byte[] ImageData { get; set; }
        public List<ClubUser> ClubUsers { get; set; }

        [Display(Name = "Avatar")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        //public virtual ICollection<Attachment> Attachments{ get; set; }
        
    }
}
