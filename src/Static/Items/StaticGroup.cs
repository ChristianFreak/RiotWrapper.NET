using Newtonsoft.Json;

namespace RiotWrapper.Static.Items
{
    public class StaticGroup
    {
        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}