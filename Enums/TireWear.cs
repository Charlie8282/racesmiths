using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum TireWear
    {
        [Display(Name = "Not Set")]
        NotSet,
        Off,
        Authentic,
        Acclerated
    }
}
