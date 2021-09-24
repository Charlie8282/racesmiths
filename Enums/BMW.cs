using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum BMW
    {
        [Display(Name = "Not Set")]
        NotSet,

        [Display(Name = "2011 1-Series Coupe")]
        _20111SeriesMCoupe,

        [Display(Name = "2011 1-Series M Coupe StanceWorks Edition")]
        _20111SeriesMCoupeStanceWorksEdition,

        [Display(Name = "1973 (2002) Turbo")]
        _19732002Turbo,

        [Display(Name = "1973 (2002) StanceWorks Edition")]
        _19732002StanceWorksEdition,

        [Display(Name = "2012 320 TC")]
        _2012320TC,

        [Display(Name = "1978 320 Turbo Group 5")]
        _1978320TurboGroup5,

        [Display(Name = "1981 M1 Procar")]
        _1981M1Procar,

        [Display(Name = "1991 M3 E30 Group A")]
        _1991M3E30GroupA,

        [Display(Name = "2012 M3 GT4")]
        _2012M3GT4,

        [Display(Name = "2016 M6 GT3")]
        _2016M6GT3,

        [Display(Name = "2016 M6 GTLM")]
        _2016M6GTLM,

        [Display(Name = "1999 V12 LMR")]
        _1999V12LMR,

        [Display(Name = "2012 Z4 GT3")]
        _2012Z4GT3
    }
}
