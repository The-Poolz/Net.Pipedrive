using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class DealProduct : AbstractDealProduct
    {
        [JsonProperty("sum_formatted")]
        public string SumFormatted { get; set; }

        [JsonProperty("quantity_formatted")]
        public string QuantityFormatted { get; set; }

        [JsonProperty("product")]
        public UpdatedProduct Product { get; set; }
    }
}
