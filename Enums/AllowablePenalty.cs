using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum AllowablePenalty
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "5 seconds")]
        Five,
        [Display(Name = "10 seconds")]
        Ten,
        [Display(Name = "15 seconds")]
        Fifteen,
        [Display(Name = "20 seconds")]
        Twenty,
        [Display(Name = "25 seconds")]
        TwentyFive,
        [Display(Name = "30 seconds")]
        Thirty
    }
}
