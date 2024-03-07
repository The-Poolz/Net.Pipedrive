using System;
using Net.Pipedrive.Converters;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class NewPayment
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("due_at")]
        [JsonConverter(typeof(DateWithoutTimeConverter))]
        public DateTime? DueAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
