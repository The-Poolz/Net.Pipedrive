using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class ProductFollower : Follower
    {
        [JsonProperty("product_id")]
        public long ProductId { get; set; }
    }
}
