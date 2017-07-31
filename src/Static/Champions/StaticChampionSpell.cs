using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Champions
{
    public class StaticChampionSpell
    {
        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("leveltip")]
        public StaticLevelTip Leveltip { get; set; }

        [JsonProperty("vars")]
        public List<StaticSpellVars> Vars { get; set; }

        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty("effect")]
        public List<object> Effect { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("Range")]
        public object Range { get; set; }

        [JsonProperty("cooldown")]
        public List<double> Cooldown { get; set; }

        [JsonProperty("cost")]
        public List<int> cost { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("effectBurn")]
        public List<string> EffectBurn { get; set; }

        [JsonProperty("altimages")]
        public List<StaticImage> AltImages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}