using Newtonsoft.Json;

namespace Wreq.Models
{
    public class Item
    {
        [JsonProperty("quality")]
        public Quality Quality;

        [JsonProperty("items")]
        public List<Item> Items;

        [JsonProperty("allowed")]
        public bool? Allowed;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("id")]
        public int? Id;
    }

    public class Language
    {
        [JsonProperty("id")]
        public int? Id;

        [JsonProperty("name")]
        public string Name;
    }

    public class Quality
    {
        [JsonProperty("id")]
        public int? Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("source")]
        public string Source;

        [JsonProperty("resolution")]
        public int? Resolution;

        [JsonProperty("modifier")]
        public string Modifier;
    }

    public class ProfilesModel
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("upgradeAllowed")]
        public bool? UpgradeAllowed;

        [JsonProperty("cutoff")]
        public int? Cutoff;

        [JsonProperty("items")]
        public List<Item> Items;

        [JsonProperty("minFormatScore")]
        public int? MinFormatScore;

        [JsonProperty("cutoffFormatScore")]
        public int? CutoffFormatScore;

        [JsonProperty("formatItems")]
        public List<object> FormatItems;

        [JsonProperty("language")]
        public Language Language;

        [JsonProperty("id")]
        public int? Id;
    }
}
