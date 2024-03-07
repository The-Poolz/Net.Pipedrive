using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class FileUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
