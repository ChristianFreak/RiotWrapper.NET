using Newtonsoft.Json;

namespace RiotWrapper.Static.ProfileIcons
{
    public class StaticProfileIconDetails
    {
        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}