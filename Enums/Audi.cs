using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Audi
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "1989 90 quattro IMSA_GTO")]
        _198990quattroIMSAGTO,
        [Display(Name = "2013 A1 quattro")]
        _2013A1quattro,
        [Display(Name = "2002 R8")]
        _2002R8,
        [Display(Name = "2015 R8 LMS")]
        _2015R8LMS,
        [Display(Name = "2015 R8 LMS Endurance")]
        _2015R8LMSEnduro,
        [Display(Name = "2016 R8 V10 plus")]
        _2016R8V10plus,
        [Display(Name = "2014 R18 e-tron quattro")]
        _2014R18etron,
        [Display(Name = "1991 V8 quattro [DLC]")]
        _1991V8quattroDTM,
    }
}
