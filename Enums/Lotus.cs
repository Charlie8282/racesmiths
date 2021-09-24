using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Lotus
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "1963 Type 25 Climax")]
        _1963Type25Climax,
        [Display(Name = "1965 Type 38 Ford")]
        _1965Type38Ford,
        [Display(Name = "1965 Type 40 Ford")]
        _1965Type40Ford,
        [Display(Name = "1967 Type 49 Cosworth")]
        _1967Type49Cosworth,
        [Display(Name = "1970 Type 49C Cosworth")]
        _1970Type49CCosworth,
        [Display(Name = "1967 Type 51")]
        _1967Type51,
        [Display(Name = "1968 Type 56")]
        _1968Type56,
        [Display(Name = "1972 Type 72D Cosworth")]
        _1972Type72DCosworth,
        [Display(Name = "1977 Type 78 Cosworth")]
        _1977Type78Cosworth,
        [Display(Name = "1986 Type 98T Renault Turbo")]
        _1986Type98TRenaultTurbo
    }
}
