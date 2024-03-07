using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class UserUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("active_flag")]
        public bool ActiveFlag { get; set; }
    }
}
