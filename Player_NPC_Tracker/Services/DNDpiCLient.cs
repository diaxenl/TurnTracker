using System.Net.Http;
using System.Threading.Tasks;

namespace Player_NPC_Tracker.Services
{
    public class DndApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUri = "https://www.dnd5eapi.co/api";

        public DndApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetAsync(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_baseUri}/{endpoint}");
            request.Headers.Add("Accept", "application/json");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
