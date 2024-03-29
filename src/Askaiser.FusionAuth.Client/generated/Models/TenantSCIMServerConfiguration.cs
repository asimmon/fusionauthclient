// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class TenantSCIMServerConfiguration : IParsable {
        /// <summary>The clientEntityTypeId property</summary>
        public Guid? ClientEntityTypeId { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The schemas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TenantSCIMServerConfiguration_schemas? Schemas { get; set; }
#nullable restore
#else
        public TenantSCIMServerConfiguration_schemas Schemas { get; set; }
#endif
        /// <summary>The serverEntityTypeId property</summary>
        public Guid? ServerEntityTypeId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantSCIMServerConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantSCIMServerConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientEntityTypeId", n => { ClientEntityTypeId = n.GetGuidValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"schemas", n => { Schemas = n.GetObjectValue<TenantSCIMServerConfiguration_schemas>(TenantSCIMServerConfiguration_schemas.CreateFromDiscriminatorValue); } },
                {"serverEntityTypeId", n => { ServerEntityTypeId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("clientEntityTypeId", ClientEntityTypeId);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteObjectValue<TenantSCIMServerConfiguration_schemas>("schemas", Schemas);
            writer.WriteGuidValue("serverEntityTypeId", ServerEntityTypeId);
        }
    }
}
