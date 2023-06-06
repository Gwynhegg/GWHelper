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
        private static HttpClient _client = new HttpClient()
        {
            BaseAddress = new Uri(App.Default.ConnectionString)
        };

        public async Task<User> GetAccount(string apiKey)
        {
            _client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(
                String.Concat(App.Default.ApiKeyPrefix, apiKey));

            HttpResponseMessage message = await _client.GetAsync("v2/account");

            if (message == null || message.StatusCode != HttpStatusCode.OK)
                return null;

            var response = await message.Content.ReadAsStringAsync();

            var user = Deserialize<User>(response);
            user.api_key = apiKey;

            return user;
        }
    }
}
