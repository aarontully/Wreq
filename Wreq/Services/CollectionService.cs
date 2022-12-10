using Newtonsoft.Json;
using System.Text;
using Wreq.Models;
using Wreq.Services.IServices;

namespace Wreq.Services
{
    public class CollectionService : ICollectionService
    {
        public async Task<List<ProfilesModel>> GetProfilesAsync(SettingsModel settingsModel)
        {
            HttpClient _client = new();
            _client.DefaultRequestHeaders.Add("X-Api-Key", $"{settingsModel.Apikey}");
            var response = await _client.GetAsync($"http://{settingsModel.Hostname}:{settingsModel.Port}/api/v3/qualityprofile");
            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var profiles = JsonConvert.DeserializeObject<List<ProfilesModel>>(content);
                return profiles;
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> PostAsync(PostModel post, SettingsModel settingsModel)
        {
            HttpClient _client = new();
            _client.DefaultRequestHeaders.Add("X-Api-Key", $"{settingsModel.Apikey}");
            var jsonbody = JsonConvert.SerializeObject(post);
            var content = new StringContent(jsonbody, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"http://{settingsModel.Hostname}:{settingsModel.Port}/api/v3/movie", content);
            if(response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
