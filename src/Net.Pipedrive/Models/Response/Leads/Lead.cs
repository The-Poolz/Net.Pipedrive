using System.Collections.Generic;
using Net.Pipedrive.Internal;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class Lead : AbstractLead, IEntityWithCustomFields
    {
        public string Note { get; set; }

        [JsonIgnore]
        public IDictionary<string, ICustomField> CustomFields { get; set; }
    }
}
