using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.SummonerSpells
{
    public class StaticSummonerSpell
    {
        [JsonProperty("vars")]
        public List<StaticSpellVars> Vars { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("cooldown")]
        public List<double> Cooldown { get; set; }

        [JsonProperty("effectBurn")]
        public List<string> EffectBurn { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("effect")]
        public List<object> Effect { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("leveltip")]
        public StaticLevelTip Leveltip { get; set; }

        [JsonProperty("modes")]
        public List<string> Modes { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty("range")]
        public object Range { get; set; }

        [JsonProperty("cost")]
        public List<int> Cost { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}