using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum KTM
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2016 X-Bow GT4")]
        _2016XBowGT4,
        [Display(Name = "2015 X-Bow R")]
        _2015XBowR
    }
}
