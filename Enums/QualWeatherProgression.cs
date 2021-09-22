using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum QualWeatherProgression
    {
        [Display(Name = "Not Set")]
        NotSet,
        Off,
        [Display(Name = "Real Time")]
        RealTime,
        [Display(Name = "2X")]
        _2X,
        [Display(Name = "5X")]
        _5X,
        [Display(Name = "10X")]
        _10X,
        [Display(Name = "15X")]
        _15X,
        [Display(Name = "20X")]
        _20X,
        [Display(Name = "25X")]
        _25X,
        [Display(Name = "30X")]
        _30X,
        [Display(Name = "40X")]
        _40X,
        [Display(Name = "50X")]
        _50X,
        [Display(Name = "60X")]
        _60X
    }
}
