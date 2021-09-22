using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Season
    {
        [Display(Name = "Not Set")]
        NotSet,
        Winter,
        Spring,
        Summer,
        Autumn,
        Snow
    }
}
