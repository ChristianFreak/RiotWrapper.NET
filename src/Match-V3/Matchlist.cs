﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Match_V3
{
    public class Matchlist
    {
        [JsonProperty("matches")]
        public List<MatchReference> Matches { get; set; }

        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }
}
