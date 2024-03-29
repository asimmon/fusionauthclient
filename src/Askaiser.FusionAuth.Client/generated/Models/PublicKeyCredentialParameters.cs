// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Supply information on credential type and algorithm to the &lt;i&gt;authenticator&lt;i&gt;.
    /// </summary>
    public class PublicKeyCredentialParameters : IParsable {
        /// <summary>A number identifying a cryptographic algorithm. Values should be registered with the &lt;a  href=&quot;https:www.iana.orgassignmentscosecose.xhtml#algorithms&quot;&gt;IANA COSE Algorithms registry&lt;a&gt;</summary>
        public CoseAlgorithmIdentifier? Alg { get; set; }
        /// <summary>Defines valid credential types. This is an extension point in the WebAuthn spec. The only defined value at this time is &quot;public-key&quot;</summary>
        public PublicKeyCredentialType? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicKeyCredentialParameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicKeyCredentialParameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alg", n => { Alg = n.GetEnumValue<CoseAlgorithmIdentifier>(); } },
                {"type", n => { Type = n.GetEnumValue<PublicKeyCredentialType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CoseAlgorithmIdentifier>("alg", Alg);
            writer.WriteEnumValue<PublicKeyCredentialType>("type", Type);
        }
    }
}
