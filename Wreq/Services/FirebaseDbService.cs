using Newtonsoft.Json;
using System.Text;
using Wreq.Models;
using Wreq.Services.IServices;

namespace Wreq.Services
{
    public class FirebaseDbService : IFirebaseDbService
    {
        private readonly string _serviceEndpoint = $"https://ombiclone-default-rtdb.firebaseio.com/";
        private readonly HttpClient _client;

        public FirebaseDbService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ProfilesModel> ReadProfiles(string user)
        {
            var result = await _client.GetAsync($"{_serviceEndpoint}users/{user}/settings/profile.json");
            if(result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                var profile = JsonConvert.DeserializeObject<ProfilesModel>(content);
                return profile;
            }
            else
            {
                return null;
            }
        }

        public async Task<SettingsModel> ReadSettings(string user, string type)
        {
            var result = await _client.GetAsync($"{_serviceEndpoint}users/{user}/settings/{type}.json");
            if(result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                var settings = JsonConvert.DeserializeObject<SettingsModel>(content);
                return settings;
            }
            else
            {
                return default;
            }
        }

        public async Task<bool> UpdateProfiles(ProfilesModel model, string user)
        {
            var jsonBody = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            var result = await _client.PatchAsync($"{_serviceEndpoint}users/{user}/settings/profile.json", content);

            if(result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateSettings(SettingsModel model, string user, string type)
        {
            var jsonBody = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            var result = await _client.PatchAsync($"{_serviceEndpoint}users/{user}/settings/{type}.json", content);

            if(result.IsSuccessStatusCode)
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
