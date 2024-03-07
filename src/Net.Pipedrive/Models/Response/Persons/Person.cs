using System.Collections.Generic;
using Net.Pipedrive.CustomFields;
using Net.Pipedrive.Internal;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class Person : AbstractPerson<UserCustomField, OrganizationCustomField, Picture>, IEntityWithCustomFields
    {
        [JsonIgnore]
        public IDictionary<string, ICustomField> CustomFields { get; set; }

        public PersonUpdate ToUpdate()
        {
            return new PersonUpdate
            {
                Name = Name,
                Email = Email,
                Phone = Phone,
                OrgId = OrgId?.Value,
                OwnerId = OwnerId?.Value,
                VisibleTo = VisibleTo,
                CustomFields = CustomFields
            };
        }
    }
}
