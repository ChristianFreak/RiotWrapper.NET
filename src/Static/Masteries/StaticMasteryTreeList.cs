using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Masteries
{
    public class StaticMasteryTreeList
    {
        [JsonProperty("masteryTreeItems")]
        public List<StaticMasteryTreeItem> MasteryTreeItems { get; set; }
    }
}