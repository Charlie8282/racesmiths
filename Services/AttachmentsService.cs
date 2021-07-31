using racesmiths.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace racesmiths.Services
{
    public class AttachmentsService
    {
        public Attachment Attach(IFormFile attachment)
        {
            Attachment Attachment = new Attachment();

            var memoryStream = new MemoryStream();
            attachment.CopyTo(memoryStream);
            byte[] bytes = memoryStream.ToArray();
            memoryStream.Close();
            memoryStream.Dispose();
            var binary = Convert.ToBase64String(bytes);
            var ext = Path.GetExtension(attachment.FileName);

            Attachment.FilePath = $"data:image/{ext};base64,{binary}";
            Attachment.FileData = bytes;
            Attachment.Created = DateTime.Now;

            return Attachment;
        }
    }
}
