﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Match_V3
{
    public class Participant
    {
        [JsonProperty("stats")]
        public ParticipantStats Stats { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("runes")]
        public List<MatchRune> Runes { get; set; }

        [JsonProperty("timeline")]
        public ParticipantTimeline Timeline { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }

        [JsonProperty("masteries")]
        public List<MatchMastery> Masteries { get; set; }

        [JsonProperty("highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }

        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }
    }
}