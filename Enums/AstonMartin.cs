using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum AstonMartin
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2017 DB11")]
        _2017DB11,
        [Display(Name = "1959 DBR1-300")]
        _1959DBR1300,
        [Display(Name = "2014 V8 Vantage GTE")]
        _2014V8VantageGTE,
        [Display(Name = "2013 V8 Vantage GT4")]
        _2013V8VantageGT4,
        [Display(Name = "2013 V12 Vantage GT3")]
        _2013V12VantageGT3,
        [Display(Name = "2015 V12 Vantage GT12")]
        _2015VantageGT12,
        [Display(Name = "2015 Vulcan")]
        _2015Vulcan

    }
}
