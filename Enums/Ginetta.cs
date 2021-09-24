using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Ginetta
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2013 G40 GT5")]
        _2013G40GT5,
        [Display(Name = "2013 G40 Junior")]
        _2013G40Junior,
        [Display(Name = "2013 G55 GT3")]
        _2013G55GT3,
        [Display(Name = "2013 G55 GT4")]
        _2013G55GT4,
        [Display(Name = "2016 G57-P2")]
        _2016G57P2,
        [Display(Name = "LMP3")]
        _2016LMP3
    }
}
