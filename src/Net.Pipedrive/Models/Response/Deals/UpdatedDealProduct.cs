using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class UpdatedDealProduct : AbstractDealProduct
    {
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }
    }
}
