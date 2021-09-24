using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Chevrolet
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "1969 Camaro Z28 Trans Am")]
        _1969CamaroZ28TransAm,
        [Display(Name = "2015 Corvette Z06")]
        _2015CorvetteC7Z06,
        [Display(Name = "2016 Corvette C7.R")]
        _2016CorvetteC7R
    }
}
