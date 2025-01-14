
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class IpPolicyCreate
    {
        // <summary>
        // human-readable description of the source IPs of this IP policy. optional, max
        // 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this IP policy. optional, max
        // 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // the IP policy action. Supported values are <c>allow</c> or <c>deny</c>
        // </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        public override string ToString()
        {
            return $"IpPolicyCreate Description={ Description }  Metadata={ Metadata }  Action={ Action } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Action?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (IpPolicyCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Action == other.Action
            );
        }

    }
}
