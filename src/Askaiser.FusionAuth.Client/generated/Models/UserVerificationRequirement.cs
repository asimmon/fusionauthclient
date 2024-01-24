// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>Used to express whether the Relying Party requires &lt;a href=&quot;https:www.w3.orgTRwebauthn-2#user-verification&quot;&gt;user verification&lt;a&gt; for the  current operation.</summary>
    public enum UserVerificationRequirement {
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "preferred")]
        Preferred,
        [EnumMember(Value = "discouraged")]
        Discouraged,
    }
}
