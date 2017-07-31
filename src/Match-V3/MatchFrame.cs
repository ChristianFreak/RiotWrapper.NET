using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Match_V3
{
    public class MatchFrame
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("participantFrames")]
        public Dictionary<int, MatchParticipantFrame> ParticipantFrames { get; set; }

        [JsonProperty("events")]
        public List<MatchEvent> Events { get; set; }
    }
}