// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>Identifies the WebAuthn workflow. This will affect the parameters used for credential creation  and request based on the Tenant configuration.</summary>
    public enum WebAuthnWorkflow {
        [EnumMember(Value = "bootstrap")]
        Bootstrap,
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "reauthentication")]
        Reauthentication,
    }
}