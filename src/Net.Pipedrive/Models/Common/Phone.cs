﻿using Newtonsoft.Json;

namespace Net.Pipedrive
{
    public class Phone
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }
}
