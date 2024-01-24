// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class CertificateInformation : IParsable {
        /// <summary>The issuer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer { get; set; }
#nullable restore
#else
        public string Issuer { get; set; }
#endif
        /// <summary>The md5Fingerprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Md5Fingerprint { get; set; }
#nullable restore
#else
        public string Md5Fingerprint { get; set; }
#endif
        /// <summary>The serialNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>The sha1Fingerprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha1Fingerprint { get; set; }
#nullable restore
#else
        public string Sha1Fingerprint { get; set; }
#endif
        /// <summary>The sha1Thumbprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha1Thumbprint { get; set; }
#nullable restore
#else
        public string Sha1Thumbprint { get; set; }
#endif
        /// <summary>The sha256Fingerprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha256Fingerprint { get; set; }
#nullable restore
#else
        public string Sha256Fingerprint { get; set; }
#endif
        /// <summary>The sha256Thumbprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha256Thumbprint { get; set; }
#nullable restore
#else
        public string Sha256Thumbprint { get; set; }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? ValidFrom { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? ValidTo { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CertificateInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"issuer", n => { Issuer = n.GetStringValue(); } },
                {"md5Fingerprint", n => { Md5Fingerprint = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"sha1Fingerprint", n => { Sha1Fingerprint = n.GetStringValue(); } },
                {"sha1Thumbprint", n => { Sha1Thumbprint = n.GetStringValue(); } },
                {"sha256Fingerprint", n => { Sha256Fingerprint = n.GetStringValue(); } },
                {"sha256Thumbprint", n => { Sha256Thumbprint = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"validFrom", n => { ValidFrom = n.GetLongValue(); } },
                {"validTo", n => { ValidTo = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("md5Fingerprint", Md5Fingerprint);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("sha1Fingerprint", Sha1Fingerprint);
            writer.WriteStringValue("sha1Thumbprint", Sha1Thumbprint);
            writer.WriteStringValue("sha256Fingerprint", Sha256Fingerprint);
            writer.WriteStringValue("sha256Thumbprint", Sha256Thumbprint);
            writer.WriteStringValue("subject", Subject);
            writer.WriteLongValue("validFrom", ValidFrom);
            writer.WriteLongValue("validTo", ValidTo);
        }
    }
}