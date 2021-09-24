using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Acura
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2017 NSX")]
        _2017NSX,
        [Display(Name = "2017 NSX GT3")]
        _2017NSXGT3
    }
}
