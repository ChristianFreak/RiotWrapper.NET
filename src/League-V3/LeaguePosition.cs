using Newtonsoft.Json;

namespace RiotWrapper.League_V3
{
    public class LeaguePosition
    {
        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("queueType")]
        public string QueueType { get; set; }

        [JsonProperty("hotStreak")]
        public bool HotStreak { get; set; }

        [JsonProperty("miniSeries")]
        public MiniSeries MiniSeries { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("veteran")]
        public bool Veteran { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }

        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("freshBlood")]
        public bool FreshBlood { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }
    }
}
