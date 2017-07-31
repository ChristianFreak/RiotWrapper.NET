using Newtonsoft.Json;

namespace RiotWrapper.Match_V3
{
    public class MatchRune
    {
        [JsonProperty("runeId")]
        public int RuneId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}