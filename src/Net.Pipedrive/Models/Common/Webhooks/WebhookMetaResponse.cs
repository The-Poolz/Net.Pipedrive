using Newtonsoft.Json;

namespace Net.Pipedrive.Models.Common.Webhooks
{
    public class WebhookMetaResponse
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
