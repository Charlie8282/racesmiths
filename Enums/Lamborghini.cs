using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Lamborghini
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2015 Huracan LP 620-2 Super Trofeo")]
        _2015HuracanLP6202SuperTrofeo,
        [Display(Name = "2015 Huracan GT3")]
        _2015HuracanGT3,
        [Display(Name = "2013 Veneno")]
        _2013Veneno
    }
}
