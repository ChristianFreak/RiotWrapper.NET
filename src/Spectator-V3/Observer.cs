using Newtonsoft.Json;

namespace RiotWrapper.Spectator_V3
{
    public class Observer
    {
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
    }
}