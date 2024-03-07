using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class OrganizationFollower : Follower
    {
        [JsonProperty("organization_id")]
        public long OrganizationId { get; set; }
    }
}
