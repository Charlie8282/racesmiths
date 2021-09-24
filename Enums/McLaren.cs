using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum McLaren
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2016 570S")]
        _2016570S,
        [Display(Name = "2015 650S GT3")]
        _2015650SGT3,
        [Display(Name = "2017 720S")]
        _2017720S,
        [Display(Name = "1992 F1")]
        _1992F1,
        [Display(Name = "1997 F1 GTR Long Tail")]
        _1997F1GTRLongTail,
        [Display(Name = "2014 P1")]
        _2014P1,
        [Display(Name = "2015 P1 GTR")]
        _2015P1GTR
    }
}
