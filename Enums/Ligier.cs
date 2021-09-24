using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Ligier
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2014 JS P2 Honda")]
        _2014JSP2Honda,
        [Display(Name = "2014 JS P2 Judd")]
        _2014JSP2Judd,
        [Display(Name = "2014 JS P2 Nissan")]
        _2014JSP2Nissan
    }
}
