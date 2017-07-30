using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static
{
    public class StaticSpellVars
    {
        [JsonProperty("ranksWith")]
        public string RanksWith { get; set; }

        [JsonProperty("dyn")]
        public string Dyn { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("coeff")]
        public List<double> Coeff { get; set; }

        [JsonProperty("key")]
        public string key { get; set; }
    }
}