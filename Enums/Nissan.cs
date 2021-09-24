using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Nissan
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "1979 280ZX Turbo IMSA GTX [DLC]")]
        _1979280ZXTurboIMSAGTX,
        [Display(Name = "1994 300ZX LM")]
        _1994300ZXLM,
        [Display(Name = "1994 300ZX IMSA GTS")]
        _1994300ZXIMSAGTS,
        [Display(Name = "1973 Fairlady 240ZG GTS-II")]
        _1973Fairlady240ZGGTSII,
        [Display(Name = "2016 GT-R R35 GT3")]
        _2016GTRR35GT3,
        [Display(Name = "2017 GT-R R35 Nismo")]
        _2017GTRR35Nismo,
        [Display(Name = "1985 GTP ZX-Turbo")]
        _1985GTPZXTurbo,
        [Display(Name = "1998 R390 GT1")]
        _1998R390GT1,
        [Display(Name = "1981 Skyline 200RS Silhouette Formula")]
        _1981Skyline2000RSSilhouetteFormula,
        [Display(Name = "1990 Skyline GT-R BNR32 Group A [DLC]")]
        _1990SkylineGTRBNR32GroupA,
        [Display(Name = "1999 Skyline GT-R R34 SMS-R")]
        _1999SkylineGTRR34SMSR
    }
}
