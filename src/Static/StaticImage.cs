using Newtonsoft.Json;

namespace RiotWrapper.Static
{
    public class StaticImage
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("sprite")]
        public string Sprite { get; set; }

        [JsonProperty("h")]
        public int h { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("x")]
        public int x { get; set; }
    }
}