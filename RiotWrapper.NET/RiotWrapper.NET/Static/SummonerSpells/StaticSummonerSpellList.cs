using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.SummonerSpells
{
    public class StaticSummonerSpellList
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticSummonerSpell> Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
