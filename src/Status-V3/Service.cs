using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Status_V3
{
    public class Service
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("incidents")]
        public List<Incident> Incidents { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}