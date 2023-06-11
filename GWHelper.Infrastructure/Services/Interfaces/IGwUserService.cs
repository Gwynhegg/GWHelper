using System.Collections.Generic;
using System.Threading.Tasks;
using GWHelper.Infrastructure.Models;

namespace GWHelper.Infrastructure.Services.Interfaces
{
    public interface IGwUserService
    {
        Task<User> GetAccount(string apiKey);
        Task<List<Achievement>> GetAchievements(string apiKey);
        Task<List<Material>> GetMaterials(string apiKey);
        Task<List<Currency>> GetCurrencies(string apiKey);
    }
}
