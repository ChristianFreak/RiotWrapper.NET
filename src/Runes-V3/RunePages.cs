using Newtonsoft.Json;
using System.Collections.Generic; 

namespace RiotWrapper.Runes_V3
{
    public class RunePages
    {
        [JsonProperty("pages")]
        public List<RunePage> Pages { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
