using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Jaguar
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "1974 E-Type V12 [DLC]")]
        _1974ETypeV12,
        [Display(Name = "2016 F-Type SVR")]
        _2016FTypeSVR,
        [Display(Name = "1994 XJ220 S TWR")]
        _1994XJ220STWR,
        [Display(Name = "1988 XJR-9")]
        _1988XJR9,
        [Display(Name = "1988 XJR-9 LM")]
        _1988XJR9LM
    }
}
