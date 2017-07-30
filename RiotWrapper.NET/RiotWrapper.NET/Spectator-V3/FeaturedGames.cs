using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Spectator_V3
{
    public class FeaturedGames
    {
        [JsonProperty("clientRefreshInterval")]
        public long ClientRefreshInterval { get; set; }

        [JsonProperty("gameList")]
        public List<FeaturedGameInfo> GameList { get; set; }
    }
}
