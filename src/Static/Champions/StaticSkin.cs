﻿using Newtonsoft.Json;

namespace RiotWrapper.Static.Champions
{
    public class StaticSkin
    {
        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}