using System.Collections.Generic;
using Net.Pipedrive.Internal;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class WebhookOrganization : AbstractOrganization<long?, long?>, IEntityWithCustomFields
    {
        [JsonIgnore]
        public IDictionary<string, ICustomField> CustomFields { get; set; }

        public OrganizationUpdate ToUpdate()
        {
            return new OrganizationUpdate
            {
                Name = Name,
                OwnerId = OwnerId,
                VisibleTo = VisibleTo,
                CustomFields = CustomFields
            };
        }
    }
}
