using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Match_V3
{
    public class MatchTimeline
    {
        [JsonProperty("frames")]
        public List<MatchFrame> Frames { get; set; }

        [JsonProperty("frameInterval")]
        public long FrameInterval { get; set; }
    }
}