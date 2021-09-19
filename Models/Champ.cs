using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using racesmiths.Enums;

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
        public string Game { get; set; }
        public string System { get; set; }

        [Required]
        public int Rounds { get; set; }
        public string Rules { get; set; }
        public int? Laps { get; set; }
        public int? RaceLength { get; set; }
        public int? QualifyLength { get; set; }
        public string Season { get; set; }
        public string WeatherSlot1 { get; set; }
        public string WeatherSlot2 { get; set; }
        public string WeatherSlot3 { get; set; }
        public string WeatherSlot4 { get; set; }
        public string IGTQualify { get; set; }
        public string IGTRace { get; set; }
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

        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} but no longer than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Championship description")]
        public string Description { get; set; }
        public string Settings { get; set; }
        public string[] SelectedUsers { get; set; }

        public bool IsPublished { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        public Status? Status { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }
        public byte[] ImageData { get; set; }

        //NAVIGATION
        public Club Club { get; set; }
        public virtual ICollection<RSUser> ChampUsers { get; set; } = new HashSet<RSUser>();


        public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();

    }
}
