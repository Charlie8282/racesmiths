using Microsoft.AspNetCore.Http;
using racesmiths.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models.ViewModels
{
    public class InfieldViewModel
    {
        public InfieldViewModel()
        {
            Champs = new List<Champ>();
            Clubs = new List<Club>();
            Events = new List<Event>();
            Races = new List<Race>();
            //ClubUser = new List<ClubUser>();
            //Attachments = new List<ChampAttachment>();
        }

        public int Remainder { get; set; }
        public int Page { get; set; }
        public List<Champ> Champs { get; set; }
        public List<Club> Clubs { get; set; }
        public List<Event> Events { get; set; }
        public List<Race> Races { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public string ChampUserId { get; set; }
        public RSUser ChampUser { get; set; }
        //public List<ClubUser> ClubUser { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        [Display(Name = "Select Image")]
        [NotMapped]
        [DataType(DataType.Upload)]
        [MaxFileSize(2 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".doc", ".xlsx", ".pdf" })]
        public IFormFile FormFile { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }


    }
}
