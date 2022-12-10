using Newtonsoft.Json;

namespace Wreq.Models
{
    public class SettingsModel
    {
        public string? Id { get; set; }

        [JsonProperty("hostname")]
        public string? Hostname { get; set; }

        [JsonProperty("port")]
        public string? Port { get; set; }

        [JsonProperty("apikey")]
        public string? Apikey { get; set; }
    }
}
