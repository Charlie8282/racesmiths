using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Honda
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2015 2&4 Concept Car [DLC]")]
        _2015sConceptCar,
        [Display(Name = "2016 Civic GRC")]
        _2016HondaCivicGRC,
        [Display(Name = "2017 Civic Type R [DLC]")]
        _2017HondaCivicTypeR
    }
}
