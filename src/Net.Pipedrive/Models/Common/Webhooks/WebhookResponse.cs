using Net.Pipedrive.Converters;
using Net.Pipedrive.Webhooks;
using Newtonsoft.Json;

namespace Net.Pipedrive.Models.Common.Webhooks
{
    public class WebhookResponse<T> : BaseWebhookResponse, IWebhookResponse<T>
    {
        [JsonConverter(typeof(WebhookNullConverter))]
        [JsonProperty("previous")]
        public T Previous { get; set; }

        [JsonConverter(typeof(WebhookNullConverter))]
        [JsonProperty("current")]
        public T Current { get; set; }
    }
}
