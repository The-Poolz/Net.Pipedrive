using Newtonsoft.Json;
using Net.Pipedrive.Webhooks;

namespace Net.Pipedrive.Models.Common.Webhooks
{
    public class BaseWebhookResponse
    {
        [JsonProperty("v")]
        public long V { get; set; }

        [JsonProperty("matches_filters")]
        public MatchesFilters MatchesFilters { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("retry")]
        public long Retry { get; set; }
    }
}
