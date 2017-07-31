using Newtonsoft.Json;

namespace RiotWrapper.Spectator_V3
{
    public class SpectatorMastery
    {
        [JsonProperty("masteryId")]
        public long MasteryId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}