using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotWrapper.Static.Items
{
    public class StaticItem
    {
        [JsonProperty("gold")]
        public StaticGold Gold { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty("inStore")]
        public bool InStore { get; set; }

        [JsonProperty("into")]
        public List<string> Into { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stats")]
        public StaticInventoryDataStats Stats { get; set; }

        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("maps")]
        public Dictionary<string, bool> Maps { get; set; }

        [JsonProperty("specialRecipe")]
        public int SpecialRecipe { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("effect")]
        public Dictionary<string, string> Effect { get; set; }

        [JsonProperty("requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonProperty("from")]
        public List<string> From { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("consumed")]
        public bool Consumed { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("stacks")]
        public int Stacks { get; }
    }
}