using System.Threading.Tasks;
using GWHelper.Infrastructure.Models;

namespace GWHelper.Infrastructure.Services.Interfaces
{
    public interface IGwUserService
    {
        Task<User> GetAccount(string apiKey);
    }
}
