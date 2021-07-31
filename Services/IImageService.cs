using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace racesmiths.Services
{
    public interface IImageService
    {
        public byte[] ConvertFileToByteArray(IFormFile file);

        public string ConvertByteArrayToFile(byte[] fileData, string extension);

        public Task<byte[]> AssignAvatarAsync(string avatar);
    }
}
