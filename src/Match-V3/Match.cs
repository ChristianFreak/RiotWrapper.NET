using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Match_V3
{
    public class Match
    {
        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }

        [JsonProperty("queueId")]
        public int QueueId { get; set; }

        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentity> ParticipantIdentities { get; set; }

        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("teams")]
        public List<TeamStats> Teams { get; set; }

        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }

        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }
    }
}
