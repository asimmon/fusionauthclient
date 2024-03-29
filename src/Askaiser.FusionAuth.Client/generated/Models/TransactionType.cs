// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>The transaction types for Webhooks and other event systems within FusionAuth.</summary>
    public enum TransactionType {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Any")]
        Any,
        [EnumMember(Value = "SimpleMajority")]
        SimpleMajority,
        [EnumMember(Value = "SuperMajority")]
        SuperMajority,
        [EnumMember(Value = "AbsoluteMajority")]
        AbsoluteMajority,
    }
}
