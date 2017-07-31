using Newtonsoft.Json;

namespace RiotWrapper.Static.Masteries
{
    public class StaticMasteryTreeItem
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty("prereq")]
        public string Prereq { get; set; }
    }
}