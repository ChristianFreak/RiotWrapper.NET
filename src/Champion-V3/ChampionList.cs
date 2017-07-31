using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Champion_V3
{
    public class ChampionList
    {
        [JsonProperty("champions")]
        public List<Champion> Champions { get; set; }
    }
}
