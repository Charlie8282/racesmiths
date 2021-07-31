using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class Notification
    {
        public int Id { get; set; }

        public int ClubId { get; set; }

        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string RecipientId { get; set; }
        public string SenderId { get; set; }
        public bool Viewed { get; set; }
        public virtual Champ Champ { get; set; }
        public virtual Event Race { get; set; }
        public virtual RSUser Recipient { get; set; }
        public virtual RSUser Sender { get; set; }


    }
}
