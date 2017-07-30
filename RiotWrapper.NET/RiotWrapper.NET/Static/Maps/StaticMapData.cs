using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Maps
{
    public class StaticMapData
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticMapDetails> Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
