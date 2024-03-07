using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class PersonFollower : Follower
    {
        [JsonProperty("person_id")]
        public long PersonId { get; set; }
    }
}
