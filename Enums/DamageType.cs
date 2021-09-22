using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum DamageType
    {
        [Display(Name = "Not Set")]
        NotSet,
        Off,
        [Display(Name = "Visual Only")]
        VisualOnly,
        [Display(Name = "Performance Only")]
        PerformanceOnly,
        [Display(Name = "Full Damage")]
        FullDamage
    }
}
