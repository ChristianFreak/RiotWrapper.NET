using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Status_V3
{
    public class Message
    {
        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("translations")]
        public List<Translation> Translations { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}