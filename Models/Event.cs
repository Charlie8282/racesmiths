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
        [Display(Name = "Event description")]
        public string Description { get; set; }

        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Event settings")]
        public string Settings { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Race Night")]
        public DateTimeOffset Scheduled { get; set; }
        public int? Laps { get; set; }
        public int? PracticeLength { get; set; }
        public int? RaceLength { get; set; }
        public int? QualifyLength { get; set; }
        public string Season { get; set; }
        public string WeatherSlot1 { get; set; }
        public string WeatherSlot2 { get; set; }
        public string WeatherSlot3 { get; set; }
        public string WeatherSlot4 { get; set; }
        public string IGTimeQualify { get; set; }
        public string IGTimeRace { get; set; }
        public string IGDateRace { get; set; }
        public string QualWeatherSlot1 { get; set; }
        public string QualWeatherSlot2 { get; set; }
        public string QualWeatherSlot3 { get; set; }
        public string QualWeatherSlot4 { get; set; }
        public string VehicleClass { get; set; }
        public string Vehicle { get; set; }
        public string ExcludeVehicle { get; set; }
        public string Multi1 { get; set; }
        public string Multi2 { get; set; }
        public string Multi3 { get; set; }
        public string Multi4 { get; set; }




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
