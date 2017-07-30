using Newtonsoft.Json;

namespace RiotWrapper.Runes_V3
{
    public class RuneSlot
    {
        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }

        [JsonProperty("runeId")]
        public int RuneId { get; set; }
    }
}