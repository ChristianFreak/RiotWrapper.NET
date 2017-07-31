using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Masteries_V3
{
    public class MasteryPages
    {
        [JsonProperty("pages")]
        public List<MasteryPage> Pages { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
