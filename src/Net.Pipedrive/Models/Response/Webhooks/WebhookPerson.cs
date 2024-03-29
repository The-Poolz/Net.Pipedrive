﻿using System.Collections.Generic;
using Net.Pipedrive.Internal;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class WebhookPerson : AbstractPerson<long?, long?, long?>, IEntityWithCustomFields
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
                OrgId = OrgId,
                OwnerId = OwnerId,
                VisibleTo = VisibleTo,
                CustomFields = CustomFields
            };
        }
    }
}
