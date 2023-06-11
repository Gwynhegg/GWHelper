using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GWHelper.Infrastructure.Models;
using GWHelper.Infrastructure.Services.Interfaces;

namespace GWHelper.Infrastructure.Services
{
    public class GwInfoService : IGwInfoService
    {
        public async Task<Item> GetItem(int id)
        {
            var item = await ResponseBuilder.GetResponse<Item>(request: id.ToString());
            return item;
        }
    }
}
