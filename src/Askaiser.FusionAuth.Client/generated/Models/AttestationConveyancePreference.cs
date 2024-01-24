// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>Used to communicate whether and how authenticator attestation should be delivered to the Relying Party</summary>
    public enum AttestationConveyancePreference {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "indirect")]
        Indirect,
        [EnumMember(Value = "direct")]
        Direct,
        [EnumMember(Value = "enterprise")]
        Enterprise,
    }
}