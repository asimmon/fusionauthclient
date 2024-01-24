// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// The &lt;i&gt;authenticator&apos;s&lt;i&gt; response for the authentication ceremony in its encoded format
    /// </summary>
    public class WebAuthnAuthenticatorAuthenticationResponse : IParsable {
        /// <summary>The authenticatorData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticatorData { get; set; }
#nullable restore
#else
        public string AuthenticatorData { get; set; }
#endif
        /// <summary>The clientDataJSON property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientDataJSON { get; set; }
#nullable restore
#else
        public string ClientDataJSON { get; set; }
#endif
        /// <summary>The signature property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Signature { get; set; }
#nullable restore
#else
        public string Signature { get; set; }
#endif
        /// <summary>The userHandle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserHandle { get; set; }
#nullable restore
#else
        public string UserHandle { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebAuthnAuthenticatorAuthenticationResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebAuthnAuthenticatorAuthenticationResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authenticatorData", n => { AuthenticatorData = n.GetStringValue(); } },
                {"clientDataJSON", n => { ClientDataJSON = n.GetStringValue(); } },
                {"signature", n => { Signature = n.GetStringValue(); } },
                {"userHandle", n => { UserHandle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authenticatorData", AuthenticatorData);
            writer.WriteStringValue("clientDataJSON", ClientDataJSON);
            writer.WriteStringValue("signature", Signature);
            writer.WriteStringValue("userHandle", UserHandle);
        }
    }
}
