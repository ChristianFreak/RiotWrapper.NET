using Newtonsoft.Json;

namespace RiotWrapper.Match_V3
{
    public class MatchMastery
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}