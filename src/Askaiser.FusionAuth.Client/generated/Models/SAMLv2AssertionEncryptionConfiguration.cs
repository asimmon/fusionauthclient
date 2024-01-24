// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class SAMLv2AssertionEncryptionConfiguration : IParsable {
        /// <summary>The digestAlgorithm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DigestAlgorithm { get; set; }
#nullable restore
#else
        public string DigestAlgorithm { get; set; }
#endif
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The encryptionAlgorithm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptionAlgorithm { get; set; }
#nullable restore
#else
        public string EncryptionAlgorithm { get; set; }
#endif
        /// <summary>The keyLocation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyLocation { get; set; }
#nullable restore
#else
        public string KeyLocation { get; set; }
#endif
        /// <summary>The keyTransportAlgorithm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyTransportAlgorithm { get; set; }
#nullable restore
#else
        public string KeyTransportAlgorithm { get; set; }
#endif
        /// <summary>The keyTransportEncryptionKeyId property</summary>
        public Guid? KeyTransportEncryptionKeyId { get; set; }
        /// <summary>The maskGenerationFunction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MaskGenerationFunction { get; set; }
#nullable restore
#else
        public string MaskGenerationFunction { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SAMLv2AssertionEncryptionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SAMLv2AssertionEncryptionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"digestAlgorithm", n => { DigestAlgorithm = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"encryptionAlgorithm", n => { EncryptionAlgorithm = n.GetStringValue(); } },
                {"keyLocation", n => { KeyLocation = n.GetStringValue(); } },
                {"keyTransportAlgorithm", n => { KeyTransportAlgorithm = n.GetStringValue(); } },
                {"keyTransportEncryptionKeyId", n => { KeyTransportEncryptionKeyId = n.GetGuidValue(); } },
                {"maskGenerationFunction", n => { MaskGenerationFunction = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("digestAlgorithm", DigestAlgorithm);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("encryptionAlgorithm", EncryptionAlgorithm);
            writer.WriteStringValue("keyLocation", KeyLocation);
            writer.WriteStringValue("keyTransportAlgorithm", KeyTransportAlgorithm);
            writer.WriteGuidValue("keyTransportEncryptionKeyId", KeyTransportEncryptionKeyId);
            writer.WriteStringValue("maskGenerationFunction", MaskGenerationFunction);
        }
    }
}