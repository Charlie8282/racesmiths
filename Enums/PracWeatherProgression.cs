using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum PracWeatherProgression
    {
        [Display(Name = "Not Set")]
        NotSet,
        Off,
        [Display(Name = "Real Time")]
        RealTime,
        [Display(Name = "2X")]
        twoX,
        [Display(Name = "5X")]
        fiveX,
        [Display(Name = "10X")]
        tenX,
        [Display(Name = "15X")]
        fifteenX,
        [Display(Name = "20X")]
        twentyX,
        [Display(Name = "25X")]
        twofiveX,
        [Display(Name = "30X")]
        thirtyX,
        [Display(Name = "40X")]
        fourtyX,
        [Display(Name = "50X")]
        fiftyX,
        [Display(Name = "60X")]
        sixtyX
    }
}
