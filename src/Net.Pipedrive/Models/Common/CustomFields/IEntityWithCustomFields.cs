using System.Collections.Generic;

namespace Net.Pipedrive
{
    public interface IEntityWithCustomFields
    {
        IDictionary<string, ICustomField> CustomFields { get; set; }
    }
}
