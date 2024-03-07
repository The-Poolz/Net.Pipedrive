using System.Collections.Generic;
using Net.Pipedrive.CustomFields;
using Net.Pipedrive.Internal;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class Organization : AbstractOrganization<UserCustomField, Picture>, IEntityWithCustomFields
    {
        [JsonIgnore]
        public IDictionary<string, ICustomField> CustomFields { get; set; }

        public OrganizationUpdate ToUpdate()
        {
            return new OrganizationUpdate
            {
                Name = Name,
                OwnerId = OwnerId?.Value,
                VisibleTo = VisibleTo,
                CustomFields = CustomFields
            };
        }
    }
}
