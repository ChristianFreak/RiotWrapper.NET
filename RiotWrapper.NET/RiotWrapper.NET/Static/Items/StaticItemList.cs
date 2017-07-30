using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Items
{
    public class StaticItemList
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticItem> Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("tree")]
        public List<StaticItemTree> Tree { get; set; }

        [JsonProperty("groups")]
        public List<StaticGroup> Groups { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
