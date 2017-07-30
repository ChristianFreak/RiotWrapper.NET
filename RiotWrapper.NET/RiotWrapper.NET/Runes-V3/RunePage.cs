using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Runes_V3
{
    public class RunePage
    {
        [JsonProperty("current")]
        public bool Current { get; set; }

        [JsonProperty("slots")]
        public List<RuneSlot> Slots { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }
}