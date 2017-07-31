using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Maps
{
    public class StaticMapDetails
    {
        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("mapId")]
        public long MapId { get; set; }

        [JsonProperty("unpurchasableItemList")]
        public List<long> UnpurchasableItems { get; set; }
    }
}