using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Mitsubishi
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "1999 Lancer Evolution VI TME")]
        _1999LancerEvolutionVITME,
        [Display(Name = "2016 Lancer Evolution VI SVA")]
        _2016LancerEvolutionVISVA,
        [Display(Name = "2008 Lancer Evolution IX FQ-360")]
        _2008LancerEvolutionIXFQ360,
        [Display(Name = "2012 Lancer Evolution X FQ-400")]
        _2012LancerEvolutionXFQ400
    }
}
