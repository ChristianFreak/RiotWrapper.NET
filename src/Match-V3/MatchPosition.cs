using Newtonsoft.Json;

namespace RiotWrapper.Match_V3
{
    public class MatchPosition
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("Y")]
        public int Y { get; set; }
    }
}