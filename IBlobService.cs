using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EventEaseBookingSystem.Services
{
    public interface IBlobService
    {
        Task<string> UploadFileAsync(IFormFile file);
    }
}
