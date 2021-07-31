using Microsoft.AspNetCore.Http;
using racesmiths.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models
{
    public class ChampAttachment
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        [Display(Name = "Select Image")]
        [NotMapped]
        [DataType(DataType.Upload)]
        [MaxFileSize(2 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".doc", ".xlsx", ".pdf" })]
        public IFormFile FormFile { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public string ContentType { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public int ChampId { get; set; }
        public virtual Champ Champ { get; set; }
        public string UserId { get; set; }
        public virtual RSUser User { get; set; }

    }
}
