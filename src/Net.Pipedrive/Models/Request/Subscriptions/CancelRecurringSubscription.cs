using System;
using Net.Pipedrive.Converters;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class CancelRecurringSubscription
    {
        [JsonProperty("end_date")]
        [JsonConverter(typeof(DateWithoutTimeConverter))]
        public DateTime EndDate { get; set; }
    }
}
