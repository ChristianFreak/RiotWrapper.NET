using Newtonsoft.Json;

namespace RiotWrapper.Spectator_V3
{
    public class SpectatorRune
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("runeId")]
        public long RuneId { get; set; }
    }
}