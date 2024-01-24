// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class SAMLv2Logout : IParsable {
        /// <summary>The behavior property</summary>
        public SAMLLogoutBehavior? Behavior { get; set; }
        /// <summary>The defaultVerificationKeyId property</summary>
        public Guid? DefaultVerificationKeyId { get; set; }
        /// <summary>The keyId property</summary>
        public Guid? KeyId { get; set; }
        /// <summary>The requireSignedRequests property</summary>
        public bool? RequireSignedRequests { get; set; }
        /// <summary>The singleLogout property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SAMLv2SingleLogout? SingleLogout { get; set; }
#nullable restore
#else
        public SAMLv2SingleLogout SingleLogout { get; set; }
#endif
        /// <summary>XML canonicalization method enumeration. This is used for the IdP and SP side of FusionAuth SAML.</summary>
        public CanonicalizationMethod? XmlSignatureC14nMethod { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SAMLv2Logout CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SAMLv2Logout();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"behavior", n => { Behavior = n.GetEnumValue<SAMLLogoutBehavior>(); } },
                {"defaultVerificationKeyId", n => { DefaultVerificationKeyId = n.GetGuidValue(); } },
                {"keyId", n => { KeyId = n.GetGuidValue(); } },
                {"requireSignedRequests", n => { RequireSignedRequests = n.GetBoolValue(); } },
                {"singleLogout", n => { SingleLogout = n.GetObjectValue<SAMLv2SingleLogout>(SAMLv2SingleLogout.CreateFromDiscriminatorValue); } },
                {"xmlSignatureC14nMethod", n => { XmlSignatureC14nMethod = n.GetEnumValue<CanonicalizationMethod>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SAMLLogoutBehavior>("behavior", Behavior);
            writer.WriteGuidValue("defaultVerificationKeyId", DefaultVerificationKeyId);
            writer.WriteGuidValue("keyId", KeyId);
            writer.WriteBoolValue("requireSignedRequests", RequireSignedRequests);
            writer.WriteObjectValue<SAMLv2SingleLogout>("singleLogout", SingleLogout);
            writer.WriteEnumValue<CanonicalizationMethod>("xmlSignatureC14nMethod", XmlSignatureC14nMethod);
        }
    }
}
