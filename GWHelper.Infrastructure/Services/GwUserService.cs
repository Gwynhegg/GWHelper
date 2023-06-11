using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GWHelper.Infrastructure.Models;
using GWHelper.Infrastructure.Services.Interfaces;
using static System.Text.Json.JsonSerializer;

namespace GWHelper.Infrastructure.Services
{
    public class GwUserService : IGwUserService
    {
        public async Task<User> GetAccount(string apiKey)
        {
            var user = await ResponseBuilder.GetResponse<User>(apiKey: apiKey);
            user.api_key = apiKey;

            return user;
        }

        public async Task<List<Achievement>> GetAchievements(string apiKey)
        {
            var achievements = await ResponseBuilder.GetResponse<List<Achievement>>(apiKey: apiKey);

            return achievements;
        }

        public async Task<List<Material>> GetMaterials(string apiKey)
        {
            var materials = await ResponseBuilder.GetResponse<List<Material>>(apiKey: apiKey);

            return materials;
        }

        public async Task<List<Currency>> GetCurrencies(string apiKey)
        {
            var currencies = await ResponseBuilder.GetResponse<List<Currency>>(apiKey: apiKey);

            return currencies;
        }
    }
}
