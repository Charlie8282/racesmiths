using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class ChampRule
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ChampId { get; set; }
    }
}
