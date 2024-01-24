// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>XML canonicalization method enumeration. This is used for the IdP and SP side of FusionAuth SAML.</summary>
    public enum CanonicalizationMethod {
        [EnumMember(Value = "exclusive")]
        Exclusive,
        [EnumMember(Value = "exclusive_with_comments")]
        Exclusive_with_comments,
        [EnumMember(Value = "inclusive")]
        Inclusive,
        [EnumMember(Value = "inclusive_with_comments")]
        Inclusive_with_comments,
    }
}