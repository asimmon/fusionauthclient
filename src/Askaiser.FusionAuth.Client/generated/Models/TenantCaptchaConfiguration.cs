// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class TenantCaptchaConfiguration : IParsable {
        /// <summary>The captchaMethod property</summary>
        public Askaiser.FusionAuth.Client.Models.CaptchaMethod? CaptchaMethod { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The secretKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretKey { get; set; }
#nullable restore
#else
        public string SecretKey { get; set; }
#endif
        /// <summary>The siteKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteKey { get; set; }
#nullable restore
#else
        public string SiteKey { get; set; }
#endif
        /// <summary>The threshold property</summary>
        public double? Threshold { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantCaptchaConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantCaptchaConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"captchaMethod", n => { CaptchaMethod = n.GetEnumValue<CaptchaMethod>(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"secretKey", n => { SecretKey = n.GetStringValue(); } },
                {"siteKey", n => { SiteKey = n.GetStringValue(); } },
                {"threshold", n => { Threshold = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CaptchaMethod>("captchaMethod", CaptchaMethod);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("secretKey", SecretKey);
            writer.WriteStringValue("siteKey", SiteKey);
            writer.WriteDoubleValue("threshold", Threshold);
        }
    }
}
