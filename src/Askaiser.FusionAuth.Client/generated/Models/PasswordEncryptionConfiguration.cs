// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Password Encryption Scheme Configuration
    /// </summary>
    public class PasswordEncryptionConfiguration : IParsable {
        /// <summary>The encryptionScheme property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptionScheme { get; set; }
#nullable restore
#else
        public string EncryptionScheme { get; set; }
#endif
        /// <summary>The encryptionSchemeFactor property</summary>
        public int? EncryptionSchemeFactor { get; set; }
        /// <summary>The modifyEncryptionSchemeOnLogin property</summary>
        public bool? ModifyEncryptionSchemeOnLogin { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PasswordEncryptionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordEncryptionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"encryptionScheme", n => { EncryptionScheme = n.GetStringValue(); } },
                {"encryptionSchemeFactor", n => { EncryptionSchemeFactor = n.GetIntValue(); } },
                {"modifyEncryptionSchemeOnLogin", n => { ModifyEncryptionSchemeOnLogin = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("encryptionScheme", EncryptionScheme);
            writer.WriteIntValue("encryptionSchemeFactor", EncryptionSchemeFactor);
            writer.WriteBoolValue("modifyEncryptionSchemeOnLogin", ModifyEncryptionSchemeOnLogin);
        }
    }
}
