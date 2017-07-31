using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.League_V3
{
    public class LeagueList
    {
        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entries")]
        public List<LeaueItem> Entries { get; set; }
    }
}
