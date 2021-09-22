using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum QualWeatherSlot4
    {
        [Display(Name = "Not Set")]
        NotSet,
        Clear,
        [Display(Name = "Light Cloud")]
        LightCloud,
        [Display(Name = "Medium Cloud")]
        MediumCloud,
        [Display(Name = "Heavy Cloud")]
        HeavyCloud,
        Overcast,
        [Display(Name = "Light Rain")]
        LightRain,
        Rain,
        Storm,
        Thunderstorm,
        Fog,
        [Display(Name = "Heavy Fog")]
        HeavyFog,
        [Display(Name = "Fog with Rain")]
        FogWRain,
        [Display(Name = "Heavy Fog with Rain")]
        HeavyFogWRain,
        Hazy,
        Snow,
        [Display(Name = "Heavy Snow")]
        HeavySnow,
        Blizzard,
        Random
    }
}
