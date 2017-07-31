using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Masteries_V3
{
    public class MasteryPage
    {
        [JsonProperty("current")]
        public bool Current { get; set; }

        [JsonProperty("masteries")]
        public List<Mastery> Masteries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}