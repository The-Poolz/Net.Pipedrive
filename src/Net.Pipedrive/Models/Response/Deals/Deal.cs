using System.Collections.Generic;
using Net.Pipedrive.CustomFields;
using Net.Pipedrive.Internal;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class Deal : AbstractDeal<UserCustomField, PersonCustomField, OrganizationCustomField>, IEntityWithCustomFields
    {
        [JsonIgnore]
        public IDictionary<string, ICustomField> CustomFields { get; set; }

        public DealUpdate ToUpdate()
        {
            return new DealUpdate
            {
                Title = Title,
                Value = Value,
                Currency = Currency,
                UserId = UserId?.Value,
                PersonId = PersonId?.Value,
                OrgId = OrgId?.Value,
                StageId = StageId,
                Status = Status,
                Probability = Probability,
                LostReason = LostReason,
                VisibleTo = VisibleTo,
                AddTime = AddTime,
                CloseTime = CloseTime,
                LostTime = LostTime,
                FirstWonTime = FirstWonTime,
                WonTime = WonTime,
                ExpectedCloseDate = ExpectedCloseDate,
                CustomFields = CustomFields
            };
        }
    }
}
