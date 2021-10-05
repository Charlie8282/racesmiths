using racesmiths.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int ChampId { get; set; }
        //public string EventUserId { get; set; }

        [Display(Name = "Round")]
        public int RoundNumber { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string TrackName { get; set; }

        [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string TrackVariant { get; set; }

        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Additional Information")]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Scheduled")]
        public DateTimeOffset Scheduled { get; set; }
        public int? Laps { get; set; }
        public int? PracticeHours { get; set; }
        public int? PracticeMinutes { get; set; }
        public int? RaceHours { get; set; }
        public int? RaceMinutes { get; set; }
        public int? QualifyHours { get; set; }
        public int? QualifyMinutes { get; set; }
        public int? EventPts { get; set; }
        public int? EventBonusPts { get; set; }
        public int? EventRevokePts { get; set; }
        public int? Position { get; set; }
        public string IGTimePractice { get; set; } //Need annotation for entering just the time
        public string IGTimeQualify { get; set; } //Need annotation for entering just the time
        public string IGTimeRace { get; set; } //Need annotation for entering just the time

        [DataType(DataType.Date)]
        [Display(Name = "Custom In-Game Date")]
        public DateTime? IGDateRace { get; set; } // In-game Date for race(s) - If IGDateType "Custom" is selcted, User will input custom date here

        //bools
        public bool NoPractice { get; set; }

        public bool NoQualify { get; set; }

        public bool NoRace { get; set; }

        public bool NoRealism { get; set; }

        public bool NoRules { get; set; }

        public bool FormationLap { get; set; }

        public bool MandatoryPit { get; set; }

        public bool AutoStart { get; set; }

        public bool ForceInnerView { get; set; }

        public bool ForceDriveLine { get; set; }

        public bool ForceSetup { get; set; }

        public bool ForceGears { get; set; }

        public bool ForceAids { get; set; }

        public bool AllowTcs { get; set; }

        public bool AllowAbs { get; set; }

        public bool AllowStm { get; set; }

        public bool MechFailure { get; set; }

        public bool AllowGhost { get; set; }

        public bool ForceManualPit { get; set; }

        public bool FuelUsage { get; set; }

        public bool ForceCoolDown { get; set; }
        public bool PitStopErrors { get; set; }

        //Rules and Penalties
        public bool RulesPenalty { get; set; }
        public bool TrackLimit { get; set; }
        public bool DriveThruPenalty { get; set; }
        public bool PitExitPenalty { get; set; }
        public bool RacingLicense { get; set; }
        public bool IsPublished { get; set; }

        [StringLength(5, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Minimum Racing License")]
        public string License { get; set; }

        public string ExcludeVehicle { get; set; }

        //Enums
        [EnumDataType(typeof(VehicleClass))]
        public VehicleClass VehicleClass { get; set; }
        public string Vehicle { get; set; }

        [EnumDataType(typeof(StartType))]
        public StartType StartType { get; set; }

        [EnumDataType(typeof(Season))]
        public Season Season { get; set; }

        [EnumDataType(typeof(IGDateType))]
        public IGDateType IGDateType { get; set; }

        [EnumDataType(typeof(TimeProgression))]
        public TimeProgression TimeProgression { get; set; }

        [EnumDataType(typeof(WeatherProgression))]
        public WeatherProgression WeatherProgression { get; set; }

        [EnumDataType(typeof(AllowablePenalty))]
        public AllowablePenalty AllowablePenalty { get; set; }

        [EnumDataType(typeof(TireWear))]
        public TireWear TireWear { get; set; }

        [EnumDataType(typeof(DamageType))]
        public DamageType DamageType { get; set; }
        [EnumDataType(typeof(Multi1))]
        public Multi1 Multi1 { get; set; }
        [EnumDataType(typeof(Multi2))]
        public Multi2 Multi2 { get; set; }
        [EnumDataType(typeof(Multi3))]
        public Multi3 Multi3 { get; set; }
        [EnumDataType(typeof(Multi4))]
        public Multi4 Multi4 { get; set; }
        [EnumDataType(typeof(PracWeatherSlot1))]
        public PracWeatherSlot1 PracWeatherSlot1 { get; set; }
        [EnumDataType(typeof(PracWeatherSlot2))]
        public PracWeatherSlot2 PracWeatherSlot2 { get; set; }
        [EnumDataType(typeof(PracWeatherSlot3))]
        public PracWeatherSlot3 PracWeatherSlot3 { get; set; }
        [EnumDataType(typeof(PracWeatherSlot4))]
        public PracWeatherSlot4 PracWeatherSlot4 { get; set; }
        [EnumDataType(typeof(QualWeatherSlot1))]
        public QualWeatherSlot1 QualWeatherSlot1 { get; set; }
        [EnumDataType(typeof(QualWeatherSlot2))]
        public QualWeatherSlot2 QualWeatherSlot2 { get; set; }
        [EnumDataType(typeof(QualWeatherSlot3))]
        public QualWeatherSlot3 QualWeatherSlot3 { get; set; }
        [EnumDataType(typeof(QualWeatherSlot4))]
        public QualWeatherSlot4 QualWeatherSlot4 { get; set; }
        [EnumDataType(typeof(WeatherSlot1))]
        public WeatherSlot1 WeatherSlot1 { get; set; }
        [EnumDataType(typeof(WeatherSlot2))]
        public WeatherSlot2 WeatherSlot2 { get; set; }
        [EnumDataType(typeof(WeatherSlot3))]
        public WeatherSlot3 WeatherSlot3 { get; set; }
        [EnumDataType(typeof(WeatherSlot4))]
        public WeatherSlot4 WeatherSlot4 { get; set; }
        [EnumDataType(typeof(PracTimeProgression))]
        public PracTimeProgression PracTimeProgression { get; set; }
        [EnumDataType(typeof(PracWeatherProgression))]
        public PracWeatherProgression PracWeatherProgression { get; set; }
        [EnumDataType(typeof(QualTimeProgression))]
        public QualTimeProgression QualTimeProgression { get; set; }
        [EnumDataType(typeof(QualWeatherProgression))]
        public QualWeatherProgression QualWeatherProgression { get; set; }




        public string[] SelectedUsers { get; set; }

        public string FileName { get; set; }
        public byte[] Image { get; set; }

        //NAVIGATION
        public virtual Champ Champ { get; set; }
        //public RSUser EventUser { get; set; }
        public virtual ICollection<RSUser> EventUsers { get; set; } = new HashSet<RSUser>();


        public virtual ICollection<Race> Races { get; set; } = new HashSet<Race>();

    }
}
