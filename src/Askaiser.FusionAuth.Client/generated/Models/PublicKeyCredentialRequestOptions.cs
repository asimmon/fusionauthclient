// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Provides the &lt;i&gt;authenticator&lt;i&gt; with the data it needs to generate an assertion.
    /// </summary>
    public class PublicKeyCredentialRequestOptions : IParsable {
        /// <summary>The allowCredentials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PublicKeyCredentialDescriptor>? AllowCredentials { get; set; }
#nullable restore
#else
        public List<PublicKeyCredentialDescriptor> AllowCredentials { get; set; }
#endif
        /// <summary>The challenge property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Challenge { get; set; }
#nullable restore
#else
        public string Challenge { get; set; }
#endif
        /// <summary>The rpId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RpId { get; set; }
#nullable restore
#else
        public string RpId { get; set; }
#endif
        /// <summary>The timeout property</summary>
        public long? Timeout { get; set; }
        /// <summary>Used to express whether the Relying Party requires &lt;a href=&quot;https:www.w3.orgTRwebauthn-2#user-verification&quot;&gt;user verification&lt;a&gt; for the  current operation.</summary>
        public UserVerificationRequirement? UserVerification { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicKeyCredentialRequestOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicKeyCredentialRequestOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowCredentials", n => { AllowCredentials = n.GetCollectionOfObjectValues<PublicKeyCredentialDescriptor>(PublicKeyCredentialDescriptor.CreateFromDiscriminatorValue)?.ToList(); } },
                {"challenge", n => { Challenge = n.GetStringValue(); } },
                {"rpId", n => { RpId = n.GetStringValue(); } },
                {"timeout", n => { Timeout = n.GetLongValue(); } },
                {"userVerification", n => { UserVerification = n.GetEnumValue<UserVerificationRequirement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PublicKeyCredentialDescriptor>("allowCredentials", AllowCredentials);
            writer.WriteStringValue("challenge", Challenge);
            writer.WriteStringValue("rpId", RpId);
            writer.WriteLongValue("timeout", Timeout);
            writer.WriteEnumValue<UserVerificationRequirement>("userVerification", UserVerification);
        }
    }
}
