using Newtonsoft.Json;

namespace RiotWrapper.Static.Champions
{
    public class StaticBlockItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}