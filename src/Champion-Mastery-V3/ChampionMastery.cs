using Newtonsoft.Json;

namespace RiotWrapper.Champion_Mastery_V3
{
    public class ChampionMastery
    {
        [JsonProperty("chestGranted")]
        public bool ChestGranted { get; set; }

        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }

        [JsonProperty("championPoints")]
        public int ChampionPoints { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("playerId")]
        public long PlayerId { get; set; }

        [JsonProperty("championPointsUntilNextLevel")]
        public long ChampionPointsUntilNextLevel { get; set; }

        [JsonProperty("championPointsSinceLastLevel")]
        public long ChampionPointsSinceLastLevel { get; set; }

        [JsonProperty("lastPlayTime")]
        public long LastPlayTime { get; set; }
    }
}
