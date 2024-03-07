using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class DealFollower : Follower
    {
        [JsonProperty("deal_id")]
        public long DealId { get; set; }
    }
}
