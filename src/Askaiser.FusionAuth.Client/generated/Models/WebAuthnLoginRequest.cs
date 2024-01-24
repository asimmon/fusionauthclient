// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Request to complete the WebAuthn registration ceremony
    /// </summary>
    public class WebAuthnLoginRequest : IParsable {
        /// <summary>The applicationId property</summary>
        public Guid? ApplicationId { get; set; }
        /// <summary>Request to authenticate with WebAuthn</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WebAuthnPublicKeyAuthenticationRequest? Credential { get; set; }
#nullable restore
#else
        public WebAuthnPublicKeyAuthenticationRequest Credential { get; set; }
#endif
        /// <summary>The ipAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>The metaData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.MetaData? MetaData { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.MetaData MetaData { get; set; }
#endif
        /// <summary>The newDevice property</summary>
        public bool? NewDevice { get; set; }
        /// <summary>The noJWT property</summary>
        public bool? NoJWT { get; set; }
        /// <summary>The origin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Origin { get; set; }
#nullable restore
#else
        public string Origin { get; set; }
#endif
        /// <summary>The rpId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RpId { get; set; }
#nullable restore
#else
        public string RpId { get; set; }
#endif
        /// <summary>The twoFactorTrustId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TwoFactorTrustId { get; set; }
#nullable restore
#else
        public string TwoFactorTrustId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebAuthnLoginRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebAuthnLoginRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationId", n => { ApplicationId = n.GetGuidValue(); } },
                {"credential", n => { Credential = n.GetObjectValue<WebAuthnPublicKeyAuthenticationRequest>(WebAuthnPublicKeyAuthenticationRequest.CreateFromDiscriminatorValue); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"metaData", n => { MetaData = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.MetaData>(Askaiser.FusionAuth.Client.Models.MetaData.CreateFromDiscriminatorValue); } },
                {"newDevice", n => { NewDevice = n.GetBoolValue(); } },
                {"noJWT", n => { NoJWT = n.GetBoolValue(); } },
                {"origin", n => { Origin = n.GetStringValue(); } },
                {"rpId", n => { RpId = n.GetStringValue(); } },
                {"twoFactorTrustId", n => { TwoFactorTrustId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("applicationId", ApplicationId);
            writer.WriteObjectValue<WebAuthnPublicKeyAuthenticationRequest>("credential", Credential);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.MetaData>("metaData", MetaData);
            writer.WriteBoolValue("newDevice", NewDevice);
            writer.WriteBoolValue("noJWT", NoJWT);
            writer.WriteStringValue("origin", Origin);
            writer.WriteStringValue("rpId", RpId);
            writer.WriteStringValue("twoFactorTrustId", TwoFactorTrustId);
        }
    }
}
