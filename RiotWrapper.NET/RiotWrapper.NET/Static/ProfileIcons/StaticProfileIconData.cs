using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.ProfileIcons
{
    public class StaticProfileIconData
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticProfileIconDetails> Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
