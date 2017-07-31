using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static
{
    public class StaticLevelTip
    {
        [JsonProperty("effect")]
        public List<string> Effect { get; set; }

        [JsonProperty("Label")]
        public List<string> Label { get; set; }
    }
}