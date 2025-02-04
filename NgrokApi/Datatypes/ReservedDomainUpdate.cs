
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedDomainUpdate : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // human-readable description of what this reserved domain will be used for
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this reserved domain. Optional,
        // max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // ID of an endpoint configuration of type http that will be used to handle inbound
        // http traffic to this domain
        // </summary>
        [JsonProperty("http_endpoint_configuration_id")]
        public string HttpEndpointConfigurationId { get; set; }
        // <summary>
        // ID of an endpoint configuration of type https that will be used to handle
        // inbound https traffic to this domain
        // </summary>
        [JsonProperty("https_endpoint_configuration_id")]
        public string HttpsEndpointConfigurationId { get; set; }
        // <summary>
        // ID of a user-uploaded TLS certificate to use for connections to targeting this
        // domain. Optional, mutually exclusive with <c>certificate_management_policy</c>.
        // </summary>
        [JsonProperty("certificate_id")]
        public string CertificateId { get; set; }
        // <summary>
        // configuration for automatic management of TLS certificates for this domain, or
        // null if automatic management is disabled. Optional, mutually exclusive with
        // <c>certificate_id</c>.
        // </summary>
        [JsonProperty("certificate_management_policy")]
        public ReservedDomainCertPolicy CertificateManagementPolicy { get; set; }

        public override string ToString()
        {
            return $"ReservedDomainUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata }  HttpEndpointConfigurationId={ HttpEndpointConfigurationId }  HttpsEndpointConfigurationId={ HttpsEndpointConfigurationId }  CertificateId={ CertificateId }  CertificateManagementPolicy={ CertificateManagementPolicy } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (HttpEndpointConfigurationId?.GetHashCode() ?? 0);

                hash = hash * 23 + (HttpsEndpointConfigurationId?.GetHashCode() ?? 0);

                hash = hash * 23 + (CertificateId?.GetHashCode() ?? 0);

                hash = hash * 23 + (CertificateManagementPolicy?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedDomainUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.HttpEndpointConfigurationId == other.HttpEndpointConfigurationId
                && this.HttpsEndpointConfigurationId == other.HttpsEndpointConfigurationId
                && this.CertificateId == other.CertificateId
                && this.CertificateManagementPolicy == other.CertificateManagementPolicy
            );
        }

    }
}
