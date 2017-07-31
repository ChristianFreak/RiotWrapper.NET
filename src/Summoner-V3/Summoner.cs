using Newtonsoft.Json;

namespace RiotWrapper.Summoner_V3
{
    public class Summoner
    {
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("id")]
        public long SummonerId { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }
    }
}
