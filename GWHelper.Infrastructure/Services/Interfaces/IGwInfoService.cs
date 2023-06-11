using System.Threading.Tasks;
using GWHelper.Infrastructure.Models;

namespace GWHelper.Infrastructure.Services.Interfaces
{
    public interface IGwInfoService
    {
        Task<Item> GetItem(int id);
    }
}