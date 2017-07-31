using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Spectator_V3
{
    public class CurrentGameParticipant
    {
        [JsonProperty("profileIconId")]
        public long ProfileIconId { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("runes")]
        public List<SpectatorRune> Runes { get; set; }

        [JsonProperty("bot")]
        public bool Bot { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }

        [JsonProperty("masteries")]
        public List<SpectatorMastery> Masteries { get; set; }

        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}