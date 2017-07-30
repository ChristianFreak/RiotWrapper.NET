using Newtonsoft.Json;

namespace RiotWrapper.Match_V3
{
    public class ParticipantIdentity
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("paricipantId")]
        public int ParicipantId { get; set; }
    }
}