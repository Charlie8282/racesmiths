using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Ferrari
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "1984 288 GTO")]
        _1984288GTO,
        [Display(Name = "1971 365 GTB4 Competizione")]
        _1971365GTB4Competizione,
        [Display(Name = "2016 488 GTE")]
        _2016488GTE,
        [Display(Name = "2016 488 GT3")]
        _2016488GT3,
        [Display(Name = "1994 F40 LM")]
        _1994F40LM,
        [Display(Name = "1996 F50 GT")]
        _1996F50GT,
        [Display(Name = "2013 LaFerrari")]
        _2013LaFerrari
    }
}
