using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Bentley
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2015/2016 Contenental GT3")]
        _2015ContinentalGT3,
        [Display(Name = "2015/2016 Contenental GT3 Endurance")]
        _2016ContenentalGT3Enduro,
        [Display(Name = "2003 Speed 8")]
        _2003Speed8
    }
}
