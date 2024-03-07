using Newtonsoft.Json;

namespace Net.Pipedrive.Webhooks
{
    public class MatchesFilters
    {
        [JsonProperty("previous")]
        public string[] Previous { get; set; }

        [JsonProperty("current")]
        public string[] Current { get; set; }
    }
}
