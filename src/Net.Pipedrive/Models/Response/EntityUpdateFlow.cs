﻿using System;
using Net.Pipedrive.Internal;
using Newtonsoft.Json;

namespace Net.Pipedrive
{
    [JsonConverter(typeof(EntityUpdateConverter))]
    public class EntityUpdateFlow
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonIgnore]
        public IDealUpdateEntity Data { get; set; }
    }
}
