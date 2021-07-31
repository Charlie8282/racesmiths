using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public int ChampId { get; set; }
        public string UserId { get; set; }
        public virtual Champ Champ { get; set; }
        public virtual RSUser RSUser { get; set; }
    }
}
