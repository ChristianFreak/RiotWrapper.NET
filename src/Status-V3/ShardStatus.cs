using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Status_V3
{
    public class ShardStatus
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region_tag")]
        public string RegionTag { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("services")]
        public List<Service> Services { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("locales")]
        public List<string> Locales { get; set; }
    }
}
