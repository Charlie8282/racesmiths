using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum Indycar
    {
        [Display(Name = "Not Set")]
        NotSet,
        [Display(Name = "2016 Dallara DW12 Chevrolet (Road Course)")]
        _2016DallaraDW12ChevroletRoadCourse,
        [Display(Name = "2016 Dallara DW12 Chevrolet (Speeedway)")]
        _2016DallaraDW12ChevroletSpeedway,
        [Display(Name = "2016 Dallara DW12 Honda (Road Course)")]
        _2016DallaraDW12HondaRoadCourse,
        [Display(Name = "2016 Dallara DW12 Honda (Speeedway)")]
        _2016DallaraDW12HondaSpeedway

    }
}
