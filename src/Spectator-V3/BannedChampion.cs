using Newtonsoft.Json;

namespace RiotWrapper.Spectator_V3
{
    public class BannedChampion
    {
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }
    }
}