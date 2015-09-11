using Newtonsoft.Json;

namespace ArtifactoryApiCSharp.Entities
{
    public class Repository
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }
}
