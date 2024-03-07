using System.Collections.Generic;
using Net.Pipedrive.Internal;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class PipelineDeal : AbstractDeal<long?, long?, long?>, IEntityWithCustomFields
    {
        [JsonIgnore]
        public IDictionary<string, ICustomField> CustomFields { get; set; }
    }
}
