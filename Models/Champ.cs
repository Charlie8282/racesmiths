using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using racesmiths.Enums;
using System.ComponentModel.DataAnnotations.Schema;


namespace racesmiths.Models
{
    public class Champ
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public string ClubUserId { get; set; }
        public string ChampUserId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Championship name")]
        public string ChampName { get; set; }

        [StringLength(30, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Video game")]
        public string Game { get; set; }

        [StringLength(30, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Gaming system")]
        public string System { get; set; }

       
        public int Rounds { get; set; }

        [StringLength(1500, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        public string Rules { get; set; }

        [StringLength(999, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        public int? Laps { get; set; }

        //Annotation for hours and minutes.  Moving in increments of 5
        public int? PracticeLength { get; set; }
        public int? RaceHours { get; set; }
        public int? RaceMinutes { get; set; }
        public int? QualifyHours { get; set; }
        public int? QualifyMinutes { get; set; }
        public string IGTimeQualify { get; set; } //Need annotation for entering just the time
        public string IGTimeRace { get; set; } //Need annotation for entering just the time

        [DataType(DataType.Date)]
        [Display(Name = "Custom In-Game Date")]
        public DateTime? IGDateRace { get; set; } // In-game Date for race(s) - If IGDateType "Custom" is selcted, User will input custom date here

        //bools
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

        //Rules and Penalties
        public bool RulesPenalty { get; set; }
        public bool TrackLimit { get; set; }
        public bool DriveThruPenalty { get; set; }
        public bool PitExitPenalty { get; set; }
        public bool RacingLicense { get; set; }

        [StringLength(5, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Minimum Racing License")]
        public string License { get; set; }

        public string ExcludeVehicle { get; set; }



        //Enums
        public string VehicleClass { get; set; }
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
        public bool IsPublished { get; set; }


        public string Multi1 { get; set; }
        public string Multi2 { get; set; }
        public string Multi3 { get; set; }
        public string Multi4 { get; set; }
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
        [EnumDataType(typeof(QualTimeProgression))]
        public QualTimeProgression QualTimeProgression { get; set; }
        [EnumDataType(typeof(QualWeatherProgression))]
        public QualWeatherProgression QualWeatherProgression { get; set; }


        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Championship description")]
        public string Description { get; set; }
        public string Settings { get; set; }
        public string[] SelectedUsers { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date")]
        public DateTimeOffset StartDate { get; set; }
        public Status Status { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }
        public byte[] ImageData { get; set; }

        //NAVIGATION
        public Club Club { get; set; }
        public virtual ICollection<RSUser> ChampUsers { get; set; } = new HashSet<RSUser>();

        public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();

    }
}
