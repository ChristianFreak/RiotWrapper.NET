using Newtonsoft.Json;

namespace RiotWrapper.Masteries_V3
{
    public class Mastery
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}