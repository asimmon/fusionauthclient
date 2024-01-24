// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Request to register a new public key with WebAuthn
    /// </summary>
    public class WebAuthnPublicKeyRegistrationRequest : IParsable {
        /// <summary>Contains extension output for requested extensions during a WebAuthn ceremony</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WebAuthnExtensionsClientOutputs? ClientExtensionResults { get; set; }
#nullable restore
#else
        public WebAuthnExtensionsClientOutputs ClientExtensionResults { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The &lt;i&gt;authenticator&apos;s&lt;i&gt; response for the registration ceremony in its encoded format</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WebAuthnAuthenticatorRegistrationResponse? Response { get; set; }
#nullable restore
#else
        public WebAuthnAuthenticatorRegistrationResponse Response { get; set; }
#endif
        /// <summary>The rpId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RpId { get; set; }
#nullable restore
#else
        public string RpId { get; set; }
#endif
        /// <summary>The transports property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Transports { get; set; }
#nullable restore
#else
        public List<string> Transports { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebAuthnPublicKeyRegistrationRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebAuthnPublicKeyRegistrationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientExtensionResults", n => { ClientExtensionResults = n.GetObjectValue<WebAuthnExtensionsClientOutputs>(WebAuthnExtensionsClientOutputs.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"response", n => { Response = n.GetObjectValue<WebAuthnAuthenticatorRegistrationResponse>(WebAuthnAuthenticatorRegistrationResponse.CreateFromDiscriminatorValue); } },
                {"rpId", n => { RpId = n.GetStringValue(); } },
                {"transports", n => { Transports = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<WebAuthnExtensionsClientOutputs>("clientExtensionResults", ClientExtensionResults);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<WebAuthnAuthenticatorRegistrationResponse>("response", Response);
            writer.WriteStringValue("rpId", RpId);
            writer.WriteCollectionOfPrimitiveValues<string>("transports", Transports);
            writer.WriteStringValue("type", Type);
        }
    }
}
