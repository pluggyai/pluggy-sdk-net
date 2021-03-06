﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pluggy.SDK.Model
{
    public class ConnectorParameters
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countries")]
        public List<string> Countries { get; set; }

        [JsonProperty("types")]
        public List<ConnectorType> Types { get; set; }

        [JsonProperty("sandbox")]
        public bool Sandbox { get; set; }

        public IDictionary<string, string> ToQueryStrings()
        {
            return new Dictionary<string, string>()
            {
                { "name", Name },
                { "countries", string.Join(",", Countries) },
                { "types", string.Join(",", Types) },
                { "sandbox", this.Sandbox.ToString().ToLower() }
            };
        }
    }
}
