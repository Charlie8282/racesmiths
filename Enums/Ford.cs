using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Ford
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "1980 Capri Zakspeed Group 5")]
        _1980CapriZakspeedGroup5,
        [Display(Name = "1972 Escort Mk1 RS1600")]
        _1972EscortMk1RS1600,
        [Display(Name = "1972 Escort Mk1 RS1600 SMS-R")]
        _1972EscortMk1RS1600SMSR,
        [Display(Name = "1972 Escort Mk1 RS1600 RX")]
        _1972EscortMk1RS1600RX,
        [Display(Name = "2015 F150 RTR Ultimate Edition")]
        _2015F150RTRUltimateFunhaver,
        [Display(Name = "2013 Falcon FG V8 Supercar")]
        _2013FalconFGV8Supercar,
        [Display(Name = "2016 Focus RS RX")]
        _2016FocusRSRX,
        [Display(Name = "2016 Fusion Stockcar")]
        _2016FusionStockcar,
        [Display(Name = "2017 GT")]
        _2017GT,
        [Display(Name = "2016 GT LM GTE")]
        _2016GTLMGTE,
        [Display(Name = "1967 GT40 MkIV")]
        _1967GT40MkIV,
        [Display(Name = "1966 Mustang 2+2 Fastback")]
        _1966MustangFastback,
        [Display(Name = "2012 Mustang Boss 302R1")]
        _2012MustangBoss302R1,
        [Display(Name = "1997 Mustang Cobra TransAm")]
        _1997MustangCobraTransAm,
        [Display(Name = "2015 Mustang GT")]
        _2015MustangGT,
        [Display(Name = "2017 Mustang RTR GT4")]
        _2017MustangRTRGT4,
        [Display(Name = "1988 Sierra RS500 Cosworth Group A")]
        _1988SierraRS500CosworthGroupA,
    }
}
