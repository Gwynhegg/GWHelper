using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Text.Json.JsonSerializer;

namespace GWHelper.Infrastructure.Services
{
    public static class ResponseBuilder
    {
        private static HttpClient _client = new HttpClient()
        {
            BaseAddress = new Uri(App.Default.ConnectionString)
        };

        public static async Task<T> GetResponse<T>(string apiKey = "")
        {
            _client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(
                String.Concat(App.Default.ApiKeyPrefix, apiKey));

            HttpResponseMessage message = await _client.GetAsync(ConstValues.ENDPOINTS[typeof(T)]);

            if (message == null || message.StatusCode != HttpStatusCode.OK)
                return default(T);

            var response = await message.Content.ReadAsStringAsync();

            if (response == null) return default(T);

            var responseData = Deserialize<T>(response);

            return responseData;
        }

        public static async Task<T> GetResponse<T>(string request = "", string apiKey = "")
        {
            _client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(
                String.Concat(App.Default.ApiKeyPrefix, apiKey));

            HttpResponseMessage message = await _client.GetAsync(ConstValues.ENDPOINTS[typeof(T)] + $"/{request}");

            if (message == null || message.StatusCode != HttpStatusCode.OK)
                return default(T);

            var response = await message.Content.ReadAsStringAsync();

            if (response == null) return default(T);

            var responseData = Deserialize<T>(response);

            return responseData;
        }
    }
}
