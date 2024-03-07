using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class PipelineMovementsAverageAgeByStage
    {
        [JsonProperty("stage_id")]
        public long StageId { get; set; }

        public decimal Value { get; set; }
    }
}
