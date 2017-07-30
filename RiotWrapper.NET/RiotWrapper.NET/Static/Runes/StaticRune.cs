using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Runes
{
    public class StaticRune
    {
        [JsonProperty("stats")]
        public StaticRuneStats Stats { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("rune")]
        public StaticMetaData Rune { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}