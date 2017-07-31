using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Masteries
{
    public class StaticMastery
    {
        [JsonProperty("prereq")]
        public string Prereq { get; set; }

        [JsonProperty("masteryTree")]
        public string MasteryTree { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ranks")]
        public int Ranks { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("sanitizedDescription")]
        public List<string> SanitizedDescription { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public List<string> Description { get; set; }
    }
}