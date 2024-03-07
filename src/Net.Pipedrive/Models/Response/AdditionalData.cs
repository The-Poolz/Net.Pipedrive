using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class AdditionalData
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
