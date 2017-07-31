using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Items
{
    public class StaticItemTree
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}