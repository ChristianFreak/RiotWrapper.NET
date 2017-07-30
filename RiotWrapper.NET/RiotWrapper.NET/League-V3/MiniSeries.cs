using Newtonsoft.Json;

namespace RiotWrapper.League_V3
{
    public class MiniSeries
    {
        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("target")]
        public int Target { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }
    }
}