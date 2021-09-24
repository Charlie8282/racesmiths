using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Mercedes
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2016 AMG A 45 SMS-R RX")]
        _2016A45SMSRRX,
        [Display(Name = "2016 AMG A 45 SMS-R Touring")]
        _2016A45SMSRTouring,
        [Display(Name = "2016 AMG C 63 Coupe S")]
        _2016C63CoupeS,
        [Display(Name = "2015 AMG GT3")]
        _2015GT3,
        [Display(Name = "2015 AMG GT R")]
        _2015GTR,
        [Display(Name = "1991 Mercedes-Benz 190E 2.5-16 Evolution2 DTM")]
        _1991190E2516Evolution2DTM,
        [Display(Name = "1971 Mercedes-Benz 300 SEL 6.8 AMG")]
        _1971300SELAMG,
        [Display(Name = "1952 Mercedes-Benz 300 SL")]
        _1952300SL,
        [Display(Name = "1998 Mercedes-Benz CLK-LM")]
        _1998CLKLM,
        [Display(Name = "2012 Mercedes-Benz SLS AMG GT3")]
        _2012SLSAMGGT3,
        [Display(Name = "1989 Sauber C9 Mercedes-Benz")]
        _1989SauberC9MercedesBenz,
        [Display(Name = "1990 Sauber C9 LM Mercedes-Benz")]
        _1990SauberC9LMMercedesBenz
    }
}
