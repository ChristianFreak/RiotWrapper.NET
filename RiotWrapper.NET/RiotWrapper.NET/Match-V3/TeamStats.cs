using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Match_V3
{
    public class TeamStats
    {
        [JsonProperty("firstDragon")]
        public bool FirstDragon { get; set; }

        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        [JsonProperty("bans")]
        public List<TeamBans> Bans { get; set; }

        [JsonProperty("int")]
        public int BaronKills { get; set; }

        [JsonProperty("firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        [JsonProperty("firstBaron")]
        public bool firstBaron { get; set; }

        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }

        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }

        [JsonProperty("vilemawKills")]
        public int VilemawKills { get; set; }

        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }

        [JsonProperty("dominionVictoryScore")]
        public int DominionVictoryScore { get; set; }

        [JsonProperty("win")]
        public string Win { get; set; }

        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }
    }
}