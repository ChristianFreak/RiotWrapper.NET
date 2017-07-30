using Newtonsoft.Json;

namespace RiotWrapper.Match_V3
{
    public class TeamBans
    {
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }
    }
}