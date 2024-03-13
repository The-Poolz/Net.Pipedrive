using Net.Pipedrive.Converters;
using Net.Pipedrive.Webhooks;
using Newtonsoft.Json;

namespace Net.Pipedrive.Models.Common.Webhooks
{
    public class WebhookResponse<T> : WebhookMetaResponse, IWebhookResponse<T>
    {
        [JsonProperty("v")]
        public long V { get; set; }

        [JsonProperty("matches_filters")]
        public MatchesFilters MatchesFilters { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("retry")]
        public long Retry { get; set; }

        [JsonConverter(typeof(WebhookNullConverter))]
        [JsonProperty("previous")]
        public T Previous { get; set; }

        [JsonConverter(typeof(WebhookNullConverter))]
        [JsonProperty("current")]
        public T Current { get; set; }
    }
}
