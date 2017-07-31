using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Status_V3
{
    public class Incident
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("updates")]
        public List<Message> Updates { get; set; }
    }
}