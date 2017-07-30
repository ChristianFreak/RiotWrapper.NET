using Newtonsoft.Json;

namespace RiotWrapper.Status_V3
{
    public class Translation
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}