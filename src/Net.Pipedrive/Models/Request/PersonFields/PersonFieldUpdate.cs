using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class PersonFieldUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public object Options { get; set; }
    }
}
